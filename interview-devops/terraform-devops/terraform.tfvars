# Lim, Chooi Guan
# https://linkedin.com/in/cgl88

aws_region   = "us-east-1"
project_name = "la-terraform"
vpc_cidr     = "10.123.0.0/16"
public_cidrs = [
  "10.123.1.0/24",
  "10.123.2.0/24"
]
accessip    = "0.0.0.0/0"
key_name = "tf_key"
public_key_path = "/home/cloud_user/.ssh/id_rsa.pub"
# Compute intensive resource
server_instance_type = "c4.large"
# server_instance_type = "t2.micro"
# Set to 1
instance_count = 1
# Set root vol size to 20 gb
root_vol_size = 20
# Set data vol size to 100 gb
data_vol_size = 100
