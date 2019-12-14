# SSE
Server Sent Event in ASP.net MVC2 to Javascript ES6

## About Server Sent Event(SSE)
SSE will allow only one way communication..Means, it will help to fire the event only from server side to client side through HTTP connection ..Usually developers will implement SSE for partial refresh or live streaming in the client side(Front end like reactjs/angular)..
       
## Definition
Server Sent Events are a standard allowing browser clients to receive a stream of updates from a server over a HTTP connection without resorting to polling. Unlike WebSockets, Server Sent Events are a one way communications channel - events flow from server to client only

## Current Integration
One-way communication from ASP.net MVC Rest API to Javascript eventSource.EventSource will be listening for the changes from the server event to trigger to process the data
