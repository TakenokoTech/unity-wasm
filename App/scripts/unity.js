var container;
var canvas;
var timer = 0;

function init() {
    document.getElementsByTagName("body")[0].style.margin = 0
    canvas = document.getElementById('unity-canvas');
    canvas.style.width = "100%"
    canvas.style.height = "100%"
}

function resize() {
    canvas.width = window.innerWidth * window.devicePixelRatio;
    canvas.height = window.innerHeight * window.devicePixelRatio;
}

(() => {
    window.onload = () => {
        init();
        resize();
    };
    
    window.onresize = () => {
        if (timer > 0) clearTimeout(timer);
        timer = setTimeout(resize, 10);
    };
})();
