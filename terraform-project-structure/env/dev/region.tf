
module "central_region" {
  source = "./region"

  environment = "${local.environment}"
  location    = "CentralUS"
}

module "east_region" {
  source = "./region"

  environment = "${local.environment}"
  location    = "EastUS2"
}
