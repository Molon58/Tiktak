
        function hideobject(id, hiddencookie) {
            var element = document.getelementbyıd(id);
            element.style.display = 'none';
            setcookie(hiddencookie, "true", 365);
        }

        function showobject(id, hiddencookie) {
            var element = document.getelementbyıd(id);
            element.style.display = 'block';
            deletecookie(hiddencookie);
        }

        window.onload = function () {
            if (getcookie("#nesnehidden") === "true") {
                hideobject('#nesne', '#nesnehidden');
            }

            if (getcookie("#nesne2hidden") === "true") {
                hideobject('#nesne2', '#nesne2hidden');
            }
        }

        window.onresize = function () {
            if (window.innerwidth <= 1867) {
                hideobject('#nesne', '#nesnehidden');
                hideobject('#nesne2', '#nesne2hidden');
            } else {
                showobject('#nesne', '#nesnehidden');
                showobject('#nesne2', '#nesne2hidden');
            }
        }

        // cookie işlemleri için setcookie ve deletecookie fonksiyonlarını tanımlamalısınız
        // bu fonksiyonlar tarayıcıda çerez oluşturup silme işlemlerini gerçekleştirir.

        //function setcookie(name, value, days) {
        //    var expires = "";
        //    if (days) {
        //        var date = new date();
        //        date.settime(date.gettime() + (days * 24 * 60 * 60 * 1000));
        //        expires = "; expires=" + date.toutcstring();
        //    }
        //    document.cookie = name + "=" + (value || "") + expires + "; path=/";
        //}

        //function getcookie(name) {
        //    var nameeq = name + "=";
        //    var ca = document.cookie.split(';');
        //    for (var i = 0; i < ca.length; i++) {
        //        var c = ca[i];
        //        while (c.charat(0) == ' ') c = c.substring(1, c.length);
        //        if (c.indexof(nameeq) == 0) return c.substring(nameeq.length, c.length);
        //    }
        //    return null;
        //}

        //function deletecookie(name) {
        //    document.cookie = name + '=; max-age=-99999999;';
        //}

    function setCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + (value || "") + expires + "; path=/";
    }

    function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
    }

    function deleteCookie(name) {
    document.cookie = name + '=; max-age=-99999999;';
    }

