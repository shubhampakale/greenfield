$(document).ready
(
    () =>
    {
        console.log("document is initialized");

        $("#btnShow").click(() => {
            console.log("buton show is clicked...");
            $("#para").show();
        });

        $("#btnHide").click(() => {
            console.log("button hide is clicked...");
            $("#para").hide();
        });
    }
);
