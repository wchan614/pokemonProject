// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function search() {
    let searchBox = document.getElementById("searchBox");
    let value = searchBox.value.toLowerCase();
  
    console.log(value);

    let content = document.getElementById("indexContents");

    for (let i = 0 ; i <  content.children.length; i++) {
        let name = content.children[i].getAttribute("name").toLowerCase();

        if (!name.includes(value)) {
            content.children[i].style.display = "none";
        }
        else {
            content.children[i].style.display = "inline-block";
        }
    }
    
}

function noenter() {
    return !(window.event && window.event.keyCode == 13); 
}

function resizeContentContainer() {
    let height = Math.max(document.documentElement.clientHeight || 0, window.innerHeight || 0);
    let content = document.getElementById("indexContents");

    let navHeight = document.getElementById("nav").offsetHeight;
    let searchHeight =$("#indexSearch").outerHeight(true);
    let footerHeight = document.getElementById("footer").offsetHeight;
    let contentHeightPad = 10;

    let contentHeight = height - navHeight - searchHeight - footerHeight - contentHeightPad;
    content.setAttribute("style","height:"+contentHeight+"px");
}



function unlockMinWidth() {

    let main = document.getElementsByTagName("main")[0];
    let nav = document.getElementsByTagName("nav")[0];
    main.setAttribute("style","min-width: 0;");
    nav.setAttribute("style","min-width: 0;");
    console.log('unlocked');

}

function lockMinWidth() {

    let main = document.getElementsByTagName("main")[0];
    let nav = document.getElementsByTagName("nav")[0];
    main.setAttribute("style","min-width: 1320px;");
    nav.setAttribute("style","min-width: 1320px;");
    console.log('locked');

}

function fixStatBars() {
    let progressBars = getElementsByClassName("progress");
    progressBars.forEach(bar => {
        bar.classList.toggle("progress");
    });
}