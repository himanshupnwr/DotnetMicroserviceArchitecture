# UdemyDotnetMicroserviceArchitecture

#Section 2
Docker commands to run in Catalog API

src path>docker ps

this will create a container for us in the catalog api project

pull mongo image from docker hub

src path>docker pull mongo

run mongo

docker run -d -p 27017:27017 --name shopping-mongo mongo

check the mongo docker image running
docker ps

check mongo logs
docker logs -f shopping-mongo

go to mongo command console where we can run mongo commands
docker exec -it shopping-mongo /bin/bash

commands to check the resources in conatiner from mongo console
root@mongoimageid:/# ls

run command to go to point to mongo interface to run its commands
mongosh

command to check the existing databases
show dbs

create new databse
use CatalogDb

create ccollections
db.createCollection('Products')

insert items in products collection
db.products.insertMany([{"Name" : "Dell Laptop","Category": "Computers","Summary": "Summary","Description": "Description","ImageFile": "ImageFile","Price": 54.93},{"Name": "HP Laptop","Category": "Computers","Summary": "Summary","Description": "Description","ImageFile": "ImageFile","Price": 88.93}])

check the objects in database
db.products.find({}).pretty()

to remove the product collection items
db.products.remove({})

