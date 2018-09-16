# APICsv
API to explore a CSV file

The folowing is an Asp .NET Web API application. It exposes API to get value by key.

The application reads a csv in the form:
key,value
three,3
two,2
ten,10

The application calls a static method on startup in Global.asax. The method which is in another class loads the CSV and stores the key value pair in a dictionary object.

Whenever a request made with "key" as a parameter. It looks for that key in dictionary object and if found returns a json conatining key value pair else it returns a standard json {"error":"No such key Exist"}

Assumptions : 
1) The csv is loaded on the applciation startup.
2) For a give key there can exist only one record.
3) The key is case sensitive.
