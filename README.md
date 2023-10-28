# Dynamic SQL to GraphQl
Implementation of a dynamic GraphQl server. The aim of the project is to dynamically retrieve the schema and data of a source db, regenerate it in a new SQL-Server instance and expose it as a GraphQl API.

## IMPORTANT NOTE - This project is currently in development and will not yet have full functionality

# Useful things to note

For development purposes, the docker-compose file stores the SQL-Server instances which correspond to the source db and the GraphQl db. 
For use of the project, please create an appsettings.development.json file and point the program at the SQL-Server instances that you would like to clone/expose.

# Project set up

1. Ensure you have docker installed. (If you would like to test the project on your own SQL instances then overwrite the appsettings with a development file and point to your SQL-Server instances.)
2. In the source directory run the command below to bring up the local SQL-Server instances
```
    docker-compose up
```
3. Run the DynamicSqlToGraphQl.API project and Swagger will pop up where you can use the GraphQl API.

# How the project will work

* On startup of the application, a background service will retrieve the source db and clone it into the GraphQl db. 
* From this database it will generate a schema, expose the schema on an endpoint and expose the data on a seperate endpoint.
* If any updates have been made to the schema/ data, the background agent will find these updates at intervals specified in the configuration and will update the schema and data.


# Project versioning - This project will be implemented in these specific versions.

## Version 0

The current state of the project, scaffolding and initial steps into building and designing the infrastructure.

## Version 1

The first version of the project will take down just the schema, recreate the tables and then expose them as a GraphQl API with no relationships.

## Version 2

The second version of the project will aim to link the tables with the correct relationships and expose these relationships through the GraphQl API.

## Version 3

The third version of the project will take down the data from the source db on startup.

## Version 4

The fourth version of the project will aim to dynamically check the source db when there are changes to the data to ensure that the data in the GraphQl db is up to date.


