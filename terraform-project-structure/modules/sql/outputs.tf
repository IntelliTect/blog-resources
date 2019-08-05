output "password" {
  value     = "${random_string.password.result}"
  sensitive = true
}
