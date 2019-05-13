$(window).scroll(function(){
    // If we have scrolled more than 10px
    if($(document).scrollTop() > 10){
        // Add class "fixed" to header element
        $('header').addClass('fixed');
    // Otherwise
    }else{
        // If header already has "fixed" class
        if($('header').hasClass('fixed')){
            // Remove said class
            $('header').removeClass('fixed');
        }
    }
});