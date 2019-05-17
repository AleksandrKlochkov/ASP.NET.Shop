$(document).ready(function () {
/*LEFT BAR MENU*/
    $('.ul-catalog-leftbar>li>div').click(function(){
    	$(this).next().slideToggle();

    leftbarCategoryhide()

    });

   $('.ul-catalog-leftbar>li>ul>li>a').mouseover(function(){   	
    	$('.ul-catalog-leftbar>li>ul>li>a').next().hide();
    	$(this).next().show();
    	//console.log($(this).text());
    	var categoryName = $(this).text();
        $(this).next().find('.nameCategory').html('<i class="fa fa-chevron-right icon"></i> '+ categoryName);
    	/*$(this).next().css('left',ulCatalogLeftBarWidth+'px');*/
    });

    $('.ul-catalog-leftbar>li>ul>li>ul>li>ul>li>a').mouseover(function(){
    	$('.ul-catalog-leftbar>li>ul>li>ul>li>ul>li>a').next().hide();
    	$(this).next().show();	
    	
    });

      $('.ul-catalog-leftbar').mouseleave(function(){
      		leftbarCategoryhide();
      });

      function leftbarCategoryhide(){
      	var categoryOne =  $('.ul-catalog-leftbar>li>ul>li>ul');
      		var categoryTwo =  $('.ul-catalog-leftbar>li>ul>li>ul>li>ul>li>ul');
      		$(categoryOne).hide();
      		$(categoryTwo).hide();
      }

/*LEFT BAR MENU*/

/*LEFT BAR FILTER*/
    $('.ul-filter-bar>li>a').click(function(){
    	$(this).next().slideToggle();
    	return false;
    });


/*LEFT BAR FILTER*/

/*DROPDOWN LIST*/
	$('.dropdown-list-b>span').click(function(){
		/*$('.dropdown-list-b>span').next().hide();*/
		$(this).next().slideToggle();


	});

	$('.dropdown-list-b>div>ul>li>a').click(function(){
		var DropdovnLineVal = $(this).text();
		$(this).closest('.dropdown-list-togle-b').prev('span').find('input').val(DropdovnLineVal);
		$(this).closest('.dropdown-list-togle-b').slideToggle();
		return false;
	}

	);

/*DROPDOWN LIST*/


});