

$(document).ready(function () {
    $(function () {
        $(".select").selectmenu();

    });

    var WinH = $(window).height();
    var contentMinHeight = WinH - 100;
    var contentHeight = WinH - 213;
    var adminLeftHeight = contentHeight - 15;
    var scroll1Height = (adminLeftHeight / 1.5);
    var scroll2Height = adminLeftHeight - scroll1Height;
    $('.contentContainer').css('min-height', contentMinHeight);
    $('#boxscroll1 .ui-jqgrid-bdiv').css('height', scroll1Height);
	$('#boxscroll2').css('height', scroll2Height);
	$('#boxscroll3').css('height', contentHeight);
	$(document).on('click', '.mobile-Menu.openMenu', function () {
	    $(this).parent().find('ul').css('display', 'block')
	    $(this).addClass('closeMenu').removeClass('openMenu');
	})
	$(document).on('click', '.mobile-Menu.closeMenu', function () {
	    $(this).parent().find('ul').css('display', 'none')
	    $(this).addClass('openMenu').removeClass('closeMenu');
	})
	$(document).on('click', '.ingredientMainList', function () {
	    $(this).parent().find('.ingredientSubList').slideToggle("fast");
	    $(this).toggleClass('ingredientMainListArrow');
	});
	



    $(window).resize(function () {
        var WinH = $(window).height();
        var contentMinHeight = WinH - 100;
        var contentHeight = WinH - 213;
        var adminLeftHeight = contentHeight - 15;
        var scroll1Height = adminLeftHeight / 1.5;
        var scroll2Height = adminLeftHeight - scroll1Height;
        $('.contentContainer').css('min-height', contentMinHeight);
        $('#boxscroll1 .ui-jqgrid-bdiv').css('height', scroll1Height);
        $('#boxscroll2').css('height', scroll2Height);
        $('#boxscroll3').css('height', contentHeight);

        $("#boxscroll1,#boxscroll2,#boxscroll3,.ItemScroll, .assignedTasksTable").mCustomScrollbar("update");
    });

});

(function ($) {
    $(window).load(function () {
        $(".customScroll").mCustomScrollbar({
            set_width: false, /*optional element width: boolean, pixels, percentage*/
            set_height: false, /*optional element height: boolean, pixels, percentage*/
            horizontalScroll: false, /*scroll horizontally: boolean*/
            scrollInertia: 0, /*scrolling inertia: integer (milliseconds)*/
            mouseWheel: true, /*mousewheel support: boolean*/
            mouseWheelPixels: "auto", /*mousewheel pixels amount: integer, "auto"*/
            autoDraggerLength: true, /*auto-adjust scrollbar dragger length: boolean*/
            autoHideScrollbar: false, /*auto-hide scrollbar when idle*/
            scrollButtons: { /*scroll buttons*/
                enable: false, /*scroll buttons support: boolean*/
                scrollType: "continuous", /*scroll buttons scrolling type: "continuous", "pixels"*/
                scrollSpeed: "auto", /*scroll buttons continuous scrolling speed: integer, "auto"*/
                scrollAmount: 40 /*scroll buttons pixels scroll amount: integer (pixels)*/
            },
            advanced: {
                updateOnBrowserResize: true, /*update scrollbars on browser resize (for layouts based on percentages): boolean*/
                updateOnContentResize: false, /*auto-update scrollbars on content resize (for dynamic content): boolean*/
                autoExpandHorizontalScroll: false, /*auto-expand width for horizontal scrolling: boolean*/
                autoScrollOnFocus: true, /*auto-scroll on focused elements: boolean*/
                normalizeMouseWheelDelta: false /*normalize mouse-wheel delta (-1/1)*/
            },
            contentTouchScroll: true, /*scrolling by touch-swipe content: boolean*/
            callbacks: {
                onScrollStart: function () { }, /*user custom callback function on scroll start event*/
                onScroll: function () { }, /*user custom callback function on scroll event*/
                onTotalScroll: function () { }, /*user custom callback function on scroll end reached event*/
                onTotalScrollBack: function () { }, /*user custom callback function on scroll begin reached event*/
                onTotalScrollOffset: 0, /*scroll end reached offset: integer (pixels)*/
                onTotalScrollBackOffset: 0, /*scroll begin reached offset: integer (pixels)*/
                whileScrolling: function () { } /*user custom callback function on scrolling event*/
            },
            theme: "dark-thick" /*"light", "dark", "light-2", "dark-2", "light-thick", "dark-thick", "light-thin", "dark-thin"*/
        });
    });
})(jQuery);