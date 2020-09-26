

function split_word(word) {

    var syllables = new Array(0);

    var vowel_start_p = true;

    while (word.length) {

        re = new RegExp(vowels);

        var index = word.search(vowels);

        if (index == 0) {
            //the vowel's at the start of word

            var matched = re.exec(word)[0]; //what is it?

            if (vowel_start_p) {
                syllables.push(("~" + matched)); //one more to the syllables

            }
            else {
                syllables.push(matched);
            }

            vowel_start_p = true;

            word = word.substring(matched.length);

        }
        else {

            re = new RegExp(consonants);

            var index = word.search(consonants);

            if (index == 0) {

                var matched = re.exec(word)[0];
                syllables.push(matched);

                vowel_start_p = false;

                word = word.substring(matched.length);


                //look ahead for virama setting

                var next = word.search(vowels);

                if (next != 0 || word.length == 0)

                    syllables.push('*');

            }
            else {

                syllables.push(word.charAt(0));

                word = word.substring(1);

            }

        }

    }    
    //while 
    return syllables;

}

//function


function match_code(syllable_mcc) {

    var matched = letter_codes[syllable_mcc];

    if (matched != null)
        return matched;

    return syllable_mcc;

}



function one_word(word_ow) {

    if (!word_ow)
        return "";

    var syllables_ow = split_word(word_ow);

    var letters_ow = new Array(0);

    document.getElementById('trail').innerHTML = "";
    for (var i_ow = 0; i_ow < syllables_ow.length; i_ow++) {
        letters_ow.push(match_code(syllables_ow[i_ow]));
        document.getElementById('trail').innerHTML = document.getElementById('trail').innerHTML + match_code(syllables_ow[i_ow]);
    }

    return letters_ow.join("");

}



function many_words(sentence) {

    var regex = "((" + vowels + ")|(" + consonants + "))+";

    var words = new Array(0);

    while (sentence.length >= 1) {

        re = new RegExp("^``" + regex);

        var match = re.exec(sentence);

        if (match != null) {

            match = match[0];
            words.push("`");
            words.push(one_word(match.substring(2)));
            
            sentence = sentence.substring(match.length);

        }
        else {

            re = new RegExp("^`" + regex);

            match = re.exec(sentence);            

            if (match != null) {

                match = match[0];

                words.push(match.substring(1));

                sentence = sentence.substring(match.length);

            }
            else {

                re = new RegExp("^" + regex);

                match = re.exec(sentence);
                                
                if (match != null) {

                    match = match[0];
                    words.push(one_word(match));

                    sentence = sentence.substring(match.length);
                }
                else {

                    words.push(sentence.charAt(0));

                    sentence = sentence.substring(1);

                }

            }

        }

    }

    return words.join("");

}


function print_many_words(index_pmw) {

    var text_pmw = many_words(document.convarea.many_words_text.value);

    var ans = "";

    while (text_pmw.length) {

        var unicode_chars = /&#[0-9]+;/;

        re = unicode_chars;
        var matche = re.exec(text_pmw);

        if (matche != null) {

            matche = matche[0];
            search = text_pmw.search(unicode_chars);

            ans += text_pmw.substring(0, search);

            ans += String.fromCharCode(matche.match(/[0-9]+/));

            text_pmw = text_pmw.substring(search + matche.length);

        }
        else {

            ans += text_pmw.substring(0);

            text_pmw = "";

        }

    }




    holdtext.innerText = ans;
    Copied = holdtext.createTextRange();
    Copied.execCommand("Copy");

    document.getElementById('trail').innerHTML = ans;
}


function cursor() {
    document.getElementById('trail').style.visibility = "visible"
    document.getElementById('trail').style.position = "absolute"
    document.getElementById('trail').style.left = event.clientX + 10
    document.getElementById('trail').style.top = event.clientY - 10
}




