function loader() {
        $( document ).ready(function() {
        $({property: 0}).animate({property: 105}, {
            duration: 1000,
            step: function() {
                var _percent = Math.round(this.property);
                $('#progress').css('width',  _percent+"%");
                if(_percent == 105) {
                    $("#progress").addClass("done");
                }
            },
        });
    });

    console.info("osu!info site created with </> by Dominic") 
}	 
