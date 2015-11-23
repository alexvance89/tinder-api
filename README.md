# Tinder API Example
An example of how a tinder api may be structured and implemented. This solution uses WebAPI 2, Owin Startup, and Ninject for Dependency Injection (IOC container).

### Available Calls
1. GET api/discoveries
--- gets a list of discovered users to like/dislike.
--- note: for a production environment, use either paged results or single user per request.
2. POST api/discoveries/like/{userId}
--- likes the specified user.
3. POST api/discoveries/dislike/{userId}
--- dislikes the specified user.
4. GET api/discoverysettings
--- gets the current users discovery settings.
5. PUT api/discoverysettings
--- updates the current users discovery settings.
6. GET api/matches
--- provides a list of matched users.
7. GET api/users/{userId}
--- provides the users profile information.

### Performance Considerations
1. Replaced JSON.NET Serializer with Jil (https://github.com/kevin-montrose/Jil)
2. Deflate compression
3. Use of Singleton Pattern throughout code (using Ninject).
4. TPL usage throughout code (async/await).

### Other Performance Considerations for a Production Envrionment
1. The use of REDIS or similar for caching.
2. Use of an Enterprise service bus for cross-system notifications/push notifications.

### Notes
1. This is not a full implementation. Things like the database interaction implementation were left out for simplicity sake.
2. This code assumes an authentication platform is also included. 
--- Ex: using an OAuth2 implementation that provides an access token with all requests on the authorization header. 
3. Database implementation emulates a database interaction with a Task.Delay(50);.
4. All requests currently ignore any queryable data passed with the request for simplicity sake.
5. A simple console application test app was written and tested with the /api/discoveries method to test performance. 
--- Current tests show about 850/calls per second.
--- System specs include Intel Core I7 3930K, 16GB DDR3 RAM, executing on a 250GB SSD.
