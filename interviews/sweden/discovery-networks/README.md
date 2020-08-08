# discovery-networks-tech-interview-devops

1. Create script to parse log for \"severity\":\"ERROR\".
2. Create Dockerfile to produce an image.
3. Run the container with the newly created image allowing you to parse generic logs.

### To build, run
`docker build . -t infra/count-dates:latest`

### To test, first copy example.log to Desktop/logs then run
`docker run -v ~/Desktop/logs/:/tmp/logs -it infra/count-dates:latest  /tmp/logs/example.log`

Expected output
```
1 2020-03-05  
8 2020-03-06
```
