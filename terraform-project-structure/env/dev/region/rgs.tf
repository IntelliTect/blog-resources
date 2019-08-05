resource "azurerm_resource_group" "sql_resource_group" {
  name     = "${local.sql_resource_group}-${local.location}"
  location = "${local.location}"

  tags = {
    environment = "${local.environment}"
  }
}
