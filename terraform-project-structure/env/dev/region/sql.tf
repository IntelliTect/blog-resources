
module "sql" {
  source = "../../../modules/sql"

  environment    = "${local.environment}"
  resource_group = "${azurerm_resource_group.sql_resource_group.name}"
  location       = "${azurerm_resource_group.sql_resource_group.location}"
}
