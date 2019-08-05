locals {
  resource_group = "${var.resource_group}"
  location       = "${var.location}"
  environment    = "${var.environment}"
}

resource "random_string" "password" {
  length  = 16
  special = true
}

resource "azurerm_sql_server" "sql_server" {
  name                         = "sql-terraform-example-${lower(local.environment)}-${lower(local.location)}"
  resource_group_name          = "${local.resource_group}"
  location                     = "${local.location}"
  version                      = "12.0"
  administrator_login          = "changeme"
  administrator_login_password = "${random_string.password.result}"

  tags = {
    environment = "${local.environment}"
  }
}
