//iife - immidiately invoked function expression
(function () {
    console.log("We are inside the iife");
    $(document).ready(function() {
        $(".col-md-4 button").on("click", function (event) {
            console.log("we are inside the button click handler");
            console.log("We are now ready to hit the ajax request");
            $.ajax({
                type: "GET",
                url: "/Employees/Index",
                dataType: "html",
                success: function (response) {
                    console.log("We have received the response");
                    console.log(response);
                    $(".well").append(response);
                }
            });
        });
    })
   
})();