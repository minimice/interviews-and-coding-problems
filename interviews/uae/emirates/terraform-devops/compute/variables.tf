# Lim, Chooi Guan
# https://linkedin.com/in/cgl88

#----compute/variables.tf----
variable "key_name" {}

variable "public_key_path" {}

variable "subnet_ips" {
  type = "list"
}

variable "instance_count" {}

variable "instance_type" {}

variable "security_group" {}

variable "root_vol_size" {}

variable "data_vol_size" {}

variable "subnets" {
  type = "list"
}
