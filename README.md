# .NET API Example


With this created web API project it can do given phrases:

- The user should have access to a repository of cars, boats, and buses with different colors (red, blue, black, white). 

- The car should be a vehicle (base class). A vehicle can have a color and buses and boats can be a vehicle. 

- The car should have wheels and headlights

## EndPoints

 ![image](https://user-images.githubusercontent.com/56580536/151660233-8aa3299f-17e6-4027-8b82-0dce9ffa4176.png)


- /api/Car/{color} 
  > This HttpGet action getting car list by color (red,black, white or blue)
  
- /api/Bus/{color} 
  > This HttpGet action getting bus list by color (red,black, white or blue)
  
- /api/Boat/{color} 
  > This HttpGet action getting boat list by color (red,black, white or blue)
  
- /api/Car/{id}
  > This HttpDelete action delete car by car's ID.
  
- /api/Car/{id}
  > This HttpPatch action turn on/off headlights of car by car’s ID. (HttpPatch action is used for best practice instead of HttpPost)
  

  
