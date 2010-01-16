jQuery.fn.watermark = function(watermark_text) {
  return this.each(function(){
        // Define what happens when the textbox comes under focus
        // Remove the watermark class and clear the box
        $(this).focus(function() {

            $(this).filter(function() {

                // We only want this to apply if there's not 
                // something actually entered
                return $(this).val() == "" || $(this).val() == watermark_text

            }).removeClass("watermark").val("");

        });

        // Define what happens when the textbox loses focus
        // Add the watermark class and default text
        $(this).blur(function() {

            $(this).filter(function() {

                // We only want this to apply if there's not
                // something actually entered
                return $(this).val() == ""

            }).addClass("watermark").val(watermark_text);

        }).blur();
  });
};