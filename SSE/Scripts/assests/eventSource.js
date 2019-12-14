var serverSentEvents = new window.EventSource('/Streaming/sseEvent');

serverSentEvents.onmessage = function (e) {
    var data = JSON.parse(e.data);
    if (data.result) {
        $("#evtMsg").append("Data Updated through Event Successfully. Passing value:<strong>" + data.result + '</strong><br />');
    }
    
};

serverSentEvents.onerror = function (e) {
    console.log('error');
};

if (typeof (window.EventSource) !== "undefined") {
    console.log('Yes! Server-sent events support!');
}
else {
    console.log('Sorry! No server-sent events support..');
}

function updateSSEData() {
    var dataPasser = $("#sseInput").val();
    $.ajax({
        url: "/Streaming/sseDataUpdate?userInputData=" + dataPasser,
        type: "GET",
        dataType: 'json',
        contentType: "application/json",
        async: true,
        processData: false,
        success: function (data) {
            var message = data.Result;
            $('#eventTriggerStatus').html(message);
        }
    });


}