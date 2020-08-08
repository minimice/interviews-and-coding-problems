#!/bin/sh

cat $1 | grep '\\"severity\\":\\"ERROR\\"' | jq '.time' | cut -c2-11 | uniq -c
