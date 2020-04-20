# Lim, Chooi Guan
# https://linkedin.com/in/cgl88

#-----compute/outputs.tf-----

output "server_id" {
  value = "${join(", ", aws_instance.tf_server.*.id)}"
}

output "server_ip" {
  value = "${join(", ", aws_instance.tf_server.*.public_ip)}"
}
