#!/bin/bash
echo "By Lim Chooi Guan for DevOps demo"
yum install httpd -y
echo "Subnet for Firewall: ${firewall_subnets}" >> /var/www/html/index.html
service httpd start
chkconfig httpd on
