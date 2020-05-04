// https://www.googleapis.com/youtube/v3/search?key=AIzaSyBGxxm4UAwVQu87LDTp9CSzAydTnboMetQ&channelId=UCdkkTU7IkCGjB_6Gw2VQozA&part=snippet,id&order=date&maxResults=20
var channelName = 'Liam Vanslingerlandt';
var vidWidth = 500;
var vidHeight = 400;
var vidResults = 10;

$(document).ready(function () {
    $.get(        
        "https://www.googleapis.com/youtube/v3/channels", {
            part: 'contentDetails',
            forUsername: channelName,
        key: 'AIzaSyBGxxm4UAwVQu87LDTp9CSzAydTnboMetQ'},
        function (data) {
            $.each(data.items, function (i, item) {
                console.log(item);
                pid = item.contentDetails.relatedPlaylists.uploads;
                getVids(pid);
            })
        }
    );

    function getVids(pid) {
        $.get(
            "https://www.googleapis.com/youtube/v3/playlistItems", {
            part: 'snippet',
                maxResults: vidResults,
                playlistId: pid,
                key: 'AIzaSyBGxxm4UAwVQu87LDTp9CSzAydTnboMetQ'},
            function (data) {
                var output;
                $.each(data.items, function (i, item) {
                    console.log(item);
                    videoTitle = item.snippet.title;

                    output = '<li><iframe height="' + vidHeight + '" width="' + vidWidth + '" src=\"//www.youtube.com/embed/' + videoId + '\"></iframe></li>';

                    //Append to results listStyleType
                    $('#results').append(output);
                })
            }
        );
    }
})
