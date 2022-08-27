# SeturDictionary
https://github.com/setur/assessment-backend-net için bir çözüm

## Install dotnet SDK

https://download.visualstudio.microsoft.com/download/pr/9a1d2e89-d785-4493-aaf3-73864627a1ea/245bdfaa9c46b87acfb2afbd10ecb0d0/dotnet-sdk-6.0.400-win-x64.exe

## Install Docker

https://docs.docker.com/desktop/install/windows-install/

## Install git

https://github.com/git-for-windows/git/releases/download/v2.37.2.windows.2/Git-2.37.2.2-64-bit.exe

## Install and Start PostgreSQL Docker Container

```bash
docker pull postgres
docker run -d --name postgres -p 5432:5432 -e POSTGRES_PASSWORD=postgres -v postgres:/var/lib/postgresql/data postgres:14
```

## Install and Start Kafka Docker Container

```bash
docker network create kafka

docker pull confluentinc/cp-zookeeper
docker pull confluentinc/cp-kafka

docker run -d --network=kafka --name=zookeeper -e ZOOKEEPER_CLIENT_PORT=2181 -e ZOOKEEPER_TICK_TIME=2000 -p 2181:2181  confluentinc/cp-zookeeper
docker run -d --network=kafka --name=kafka -e KAFKA_ZOOKEEPER_CONNECT=zookeeper:2181 -e KAFKA_ADVERTISED_LISTENERS=PLAINTEXT://localhost:9092 -p 9092:9092  confluentinc/cp-kafka
```

## Clone this project

```bash
git clone https://github.com/ogu83/SeturDictionary.git
```

## Run Directory Microservice

```bash
cd DirectoryService
docker build -t directoryservice .
docker run -it --rm -p 3000:80 --name directoryservicecontainer directoryservice
```

## Run Report Microservice

```bash
cd ReportService
docker build -t reportservice .
docker run -it --rm -p 3001:80 --name reportservicecontainer reportservice
```
