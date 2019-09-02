# Lim, Chooi Guan
# https://linkedin.com/in/cgl88

#----networking/variables.tf----
variable "vpc_cidr" {}

variable "public_cidrs" {
  type = "list"
}

variable "accessip" {}
