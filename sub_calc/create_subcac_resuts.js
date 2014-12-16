
// This will build a html table of ipaddresses, you can just ignore it.
// The idea is if you want a print the subnet you calculated.
function tableBuilder(div) {
    var d = document.getElementById(div);
    d.innerHTML = "";
    var t = document.createElement("table");
    t.border = 1;
    var b = document.createElement("tbody");
    var r = null;
    var c = null;
    d.appendChild(t);
    for (var i = 0; i < 10; i++) {
        r = document.createElement("tr");
        for (var j = 0; j < 8; j++) {
            c = document.createElement("td");
            var txt = document.createTextNode(i + ":" + j);
            c.appendChild(txt);
            r.appendChild(c);
        }
        b.appendChild(r);
    }
    t.appendChild(b);
    d.appendChild(t);
}