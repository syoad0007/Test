$(function(){

    $('.SelectRow').click(function () {

        //alert("NIG");

        //行番号取得
        var selectRow = $(this).index();
        
        //if ($(this).hasClass('ChangeRow')) {
            
        //}



        $(this).toggleClass('ChangeRow');

        

    });


});
