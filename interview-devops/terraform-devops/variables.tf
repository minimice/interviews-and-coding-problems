# Lim, Chooi Guan
# https://linkedin.com/in/cgl88

#----root/variables.tf-----
variable "aws_region" {}

#-------networking variables
variable "vpc_cidr" {}
variable "public_cidrs" {
  type = "list"
}
variable "accessip" {}

#-------compute variables
variable "key_name" {}
variable "public_key_path" {}
variable "server_instance_type" {}
variable "instance_count" {
  default = 1
}
variable "data_vol_size" {}
variable "root_vol_size" {}
