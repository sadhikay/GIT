# WebApplication
This is an Asp.net web application to view data associated with accounts. 

This application takes the value as input and fetches the data assiciated with it in the database and displys the data in the form of table in the UI.

The application in built in MVC architechture. Where view is written in jQuery, controller and model are written in C#. It used Ajax calls to call the methods in contoller and the data from controller is returned back in jSon object. 

A table named Accounts is created in SQL server with three columns(Number, Name and Balance) and data is added to it respectively. The required configuration of the application with database is done in 'WebConfig' file.


### Files with required code

View : About.cshtml(In Views > Home folder)

Conrtoller : HomeController.cs

Model: myModel.cs

