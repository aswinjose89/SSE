<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
            The EventSource interface is web content's interface to server-sent events. An EventSource instance opens a persistent connection to an HTTP server, which sends events in text/event-stream format. The connection remains open until closed by calling EventSource.close().

        Once the connection is opened, incoming messages from the server are delivered to your code in the form of events. If there is an event field in the incoming message, the triggered event is the same as the event field value. If no event field is present, then a generic message event is fired.

        Unlike WebSockets, server-sent events are unidirectional; that is, data messages are delivered in one direction, from the server to the client (such as a user's web browser). That makes them an excellent choice when there's no need to send data from the client to the server in message form. For example, EventSource is a useful approach for handling things like social media status updates, news feeds, or delivering data into a client-side storage mechanism like IndexedDB or web storage.
    </p>
    <p>
        <input type="button" value="Post AJAX To Pass data" onclick="updateSSEData()"/>
        <input type="text" value="Dynamic text" id="sseInput" placeholder="Enter the value to update event.."/>
        <div id="eventTriggerStatus"></div>
        <div id="evtMsg"></div>
    </p>
</asp:Content>
