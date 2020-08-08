# To build
# docker build . -t infra/count-dates:latest
#
# To test, copy example.log to Desktop/logs
# docker run -v ~/Desktop/logs/:/tmp/logs -it infra/count-dates:latest  /tmp/logs/example.log
#
# Expected output
#
# 1 2020-03-05
# 8 2020-03-06
#

FROM bash:latest

WORKDIR .

RUN apk add jq

COPY ./count-dates.sh .

RUN chmod 777 ./count-dates.sh

ENTRYPOINT ["./count-dates.sh"]