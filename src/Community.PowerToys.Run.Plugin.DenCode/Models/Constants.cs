namespace Community.PowerToys.Run.Plugin.DenCode.Models
{
    public static class Constants
    {
        public const string AllRequest =
"""
{
    "type": "all",
    "method": "all.all",
    "value": null,
    "oe": "UTF-8",
    "nl": "crlf",
    "tz": "UTC",
    "options": {}
}
""";

        public const string Methods =
"""
{
    "all.all": {
        "Key": "all.all",
        "useOe": true,
        "useNl": true,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": null,
        "title": "Encoding \u0026 Decoding Online Tools",
        "desc": "Encoding and Decoding site. e.g. HTML Escape / URL Encoding / Base64 / MD5 / SHA-1 / CRC32 / and many other String, Number, DateTime, Color, Hash formats!",
        "tooltip": "Please input converting value here. (e.g. String: \u0022Hello, world!\u0022 / Number: \u00221234567890\u0022 / Date: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 / Color: \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022)",
        "label": {}
    },
    "string.all": {
        "Key": "string.all",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "String - ALL",
        "title": "String Encoding \u0026 Decoding Converter Online (HTML Escape / URL Encoding / Base64 / Quoted-printable)",
        "desc": "String encoding and decoding converter. e.g. HTML Escape / URL Encoding / Quoted-printable / and many other formats!",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022)",
        "label": {}
    },
    "string.bin": {
        "Key": "string.bin",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Bin String",
        "title": "Binary String Converter Online",
        "desc": "Binary String Converter. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u002201001000 01100101 01101100 01101100 01101111 00101100 00100000 01110111 01101111 01110010 01101100 01100100 00100001\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u002201001000 01100101 01101100 01101100 01101111 00101100 00100000 01110111 01101111 01110010 01101100 01100100 00100001\u0022)",
        "label": {
            "encStrBin": "Bin String",
            "decStrBin": "Bin String",
            "encStrBin.option.separator": "Separator",
            "encStrBin.option.separator.each.none": "none",
            "encStrBin.option.separator.each.4bits": "Each 4 bits",
            "encStrBin.option.separator.each.8bits": "Each 8 bits (1 Byte)",
            "encStrBin.option.separator.each.16bits": "Each 16 bits (2 Bytes)",
            "encStrBin.option.separator.each.24bits": "Each 24 bits (3 Bytes)",
            "encStrBin.option.separator.each.32bits": "Each 32 bits (4 Bytes)",
            "encStrBin.option.separator.each.64bits": "Each 64 bits (8 Bytes)",
            "encStrBin.option.separator.each.128bits": "Each 128 bits (16 Bytes)"
        }
    },
    "string.hex": {
        "Key": "string.hex",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Hex String",
        "title": "Hexadecimal String Converter Online",
        "desc": "Hexadecimal String Converter. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u002248 65 6C 6C 6F 2C 20 77 6F 72 6C 64 21\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u002248 65 6C 6C 6F 2C 20 77 6F 72 6C 64 21\u0022)",
        "label": {
            "encStrHex": "Hex String",
            "decStrHex": "Hex String",
            "encStrHex.option.separator": "Separator",
            "encStrHex.option.separator.each.none": "none",
            "encStrHex.option.separator.each.1byte": "Each 1 Byte",
            "encStrHex.option.separator.each.2bytes": "Each 2 Bytes",
            "encStrHex.option.separator.each.3bytes": "Each 3 Bytes",
            "encStrHex.option.separator.each.4bytes": "Each 4 Bytes",
            "encStrHex.option.separator.each.8bytes": "Each 8 Bytes",
            "encStrHex.option.separator.each.16bytes": "Each 16 Bytes",
            "encStrHex.option.case": "Case",
            "encStrHex.option.case.lower": "Lower (a-f)",
            "encStrHex.option.case.upper": "Upper (A-F)"
        }
    },
    "string.html-escape": {
        "Key": "string.html-escape",
        "useOe": false,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "HTML Escape",
        "title": "HTML5 Escape / Unescape (Encoder / Decoder) Online",
        "desc": "HTML5 Escape / Unescape (Encoder / Decoder). (e.g. \u0022\u003Cp\u003EHello, world!\u003C/p\u003E\u0022 \u003C=\u003E \u0022\u0026lt;p\u0026gt;Hello, world!\u0026lt;/p\u0026gt;\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022\u003Cp\u003EHello, world!\u003C/p\u003E\u0022 \u003C=\u003E \u0022\u0026lt;p\u0026gt;Hello, world!\u0026lt;/p\u0026gt;\u0022)",
        "label": {
            "encStrHTMLEscape": "HTML Escape (Basic)",
            "encStrHTMLEscapeFully": "HTML Escape (Fully)",
            "decStrHTMLEscape": "HTML Escape"
        }
    },
    "string.url-encoding": {
        "Key": "string.url-encoding",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "URL Encoding",
        "title": "URL Encoding Encoder / Decoder Online",
        "desc": "URL Encoding Encoder / Decoder. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022Hello%2C%20world%21\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022Hello%2C%20world%21\u0022)",
        "label": {
            "encStrURLEncoding": "URL Encoding",
            "encStrURLEncoding.option.space": "Space",
            "encStrURLEncoding.option.space.default": "%20 (Percent encoding)",
            "encStrURLEncoding.option.space.form": "\u002B (application/x-www-form-urlencoded)",
            "decStrURLEncoding": "URL Encoding"
        }
    },
    "string.punycode": {
        "Key": "string.punycode",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Punycode IDN",
        "title": "Punycode IDN domain name Converter Online",
        "desc": "Punycode IDN domain name Converter. (e.g. \u0022\\u30c9\\u30e1\\u30a4\\u30f3.com\u0022 \u003C=\u003E \u0022xn--eckwd4c7c.com\u0022)",
        "tooltip": "Please input converting domain name here. (e.g. \u0022\\u30c9\\u30e1\\u30a4\\u30f3.com\u0022 \u003C=\u003E \u0022xn--eckwd4c7c.com\u0022)",
        "label": {
            "encStrPunycode": "Punycode IDN",
            "decStrPunycode": "Punycode IDN"
        }
    },
    "string.base32": {
        "Key": "string.base32",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Base32",
        "title": "Base32 Encoder / Decoder Online",
        "desc": "Base32 Encoder / Decoder. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022JBSWY3DPFQQHO33SNRSCC===\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022JBSWY3DPFQQHO33SNRSCC===\u0022)",
        "label": {
            "encStrBase32": "Base32",
            "decStrBase32": "Base32"
        }
    },
    "string.base45": {
        "Key": "string.base45",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Base45",
        "title": "Base45 Encoder / Decoder Online",
        "desc": "Base45 Encoder / Decoder. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022%69 VDK2EV4404ESVDX0\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022%69 VDK2EV4404ESVDX0\u0022)",
        "label": {
            "encStrBase45": "Base45",
            "decStrBase45": "Base45",
            "decStrBase45ZlibCoseCbor": "Base45/Zlib/COSE/CBOR"
        }
    },
    "string.base64": {
        "Key": "string.base64",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Base64",
        "title": "Base64 Encoder / Decoder Online",
        "desc": "Base64 Encoder / Decoder. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022SGVsbG8sIHdvcmxkIQ==\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022SGVsbG8sIHdvcmxkIQ==\u0022)",
        "label": {
            "encStrBase64": "Base64",
            "decStrBase64": "Base64",
            "encStrBase64.option.lineBreak": "Line Break",
            "encStrBase64.option.lineBreak.each.none": "none",
            "encStrBase64.option.lineBreak.each.64": "Each 64 chars (PEM - RFC 1421)",
            "encStrBase64.option.lineBreak.each.76": "Each 76 chars (MIME - RFC 2045)"
        }
    },
    "string.ascii85": {
        "Key": "string.ascii85",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Ascii85",
        "title": "Ascii85 Z85/Adobe/bota Encoder / Decoder Online",
        "desc": "Ascii85 Z85/Adobe/bota Encoder / Decoder. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022nm=QNz.92Pz/PV8aP\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022nm=QNz.92Pz/PV8aP\u0022)",
        "label": {
            "encStrAscii85": "Ascii85",
            "decStrAscii85": "Ascii85",
            "encStrAscii85.option.variant": "Variant",
            "encStrAscii85.option.variant.z85": "Z85 (ZeroMQ)",
            "encStrAscii85.option.variant.adobe": "Adobe",
            "encStrAscii85.option.variant.btoa": "btoa"
        }
    },
    "string.quoted-printable": {
        "Key": "string.quoted-printable",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Quoted-printable",
        "title": "Quoted-printable Encoder / Decoder Online",
        "desc": "Quoted-printable Encoder / Decoder. (e.g. \u0022Hello, != world!\u0022 \u003C=\u003E \u0022Hello, !=3D world!\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, != world!\u0022 \u003C=\u003E \u0022Hello, !=3D world!\u0022)",
        "label": {
            "encStrQuotedPrintable": "Quoted-printable",
            "decStrQuotedPrintable": "Quoted-printable"
        }
    },
    "string.unicode-escape": {
        "Key": "string.unicode-escape",
        "useOe": false,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Unicode Escape",
        "title": "Unicode Escape / Unescape (Encoder / Decoder) Online",
        "desc": "Unicode Escape / Unescape (Encoder / Decoder). (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022\\\\u0048\\\\u0065\\\\u006c\\\\u006c\\\\u006f\\\\u002c\\\\u0020\\\\u0077\\\\u006f\\\\u0072\\\\u006c\\\\u0064\\\\u0021\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022\\\\u0048\\\\u0065\\\\u006c\\\\u006c\\\\u006f\\\\u002c\\\\u0020\\\\u0077\\\\u006f\\\\u0072\\\\u006c\\\\u0064\\\\u0021\u0022)",
        "label": {
            "encStrUnicodeEscape": "Unicode Escape",
            "decStrUnicodeEscape": "Unicode Escape",
            "encStrUnicodeEscape.option.surrogatePair": "Surrogate Pair",
            "encStrUnicodeEscape.option.surrogatePair.format.uuCodeUnit": "\\\\uXXXX\\\\uXXXX - Java, JS(ES5)",
            "encStrUnicodeEscape.option.surrogatePair.format.uBracketCodePoint": "\\\\u{XXXXX} - Swift, JS(ES6\u002B), PHP, Ruby",
            "encStrUnicodeEscape.option.surrogatePair.format.UCodePoint": "\\\\U000XXXXX - C, Python"
        }
    },
    "string.program-string": {
        "Key": "string.program-string",
        "useOe": false,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Program String",
        "title": "Program String Escape / Unescape (Encoder / Decoder) Online",
        "desc": "Program String Escape / Unescape (Encoder / Decoder). (e.g. \u0022Hello,\tworld!\u0022 \u003C=\u003E \u0022\u0022Hello,\\\\tworld!\u0022\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello,\tworld!\u0022 \u003C=\u003E \u0022\u0022Hello,\\\\tworld!\u0022\u0022)",
        "label": {
            "encStrProgramString": "Program String",
            "encStrProgramString.option.quotes": "Quotes",
            "encStrProgramString.option.quotes.double": "Double (\u0022)",
            "encStrProgramString.option.quotes.single": "Single (\u0027)",
            "encStrProgramString.option.quotes.none": "None",
            "decStrProgramString": "Program String"
        }
    },
    "string.morse-code": {
        "Key": "string.morse-code",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Morse Code",
        "title": "Morse Code Translator Online",
        "desc": "Morse Code Translator. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022.... . .-.. .-.. --- --..-- / .-- --- .-. .-.. -.. -.-.--\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022.... . .-.. .-.. --- --..-- / .-- --- .-. .-.. -.. -.-.--\u0022)",
        "label": {
            "encStrMorseCode": "Morse Code",
            "encStrMorseCode.option.variant": "Variant",
            "encStrMorseCode.option.variant.international": "International (Latin)",
            "encStrMorseCode.option.variant.japanese": "Japanese",
            "encStrMorseCode.option.variant.russian": "Russian",
            "decStrMorseCode": "Morse Code",
            "decStrMorseCode.option.variant": "Variant",
            "decStrMorseCode.option.variant.international": "International (Latin)",
            "decStrMorseCode.option.variant.japanese": "Japanese",
            "decStrMorseCode.option.variant.russian": "Russian"
        }
    },
    "string.naming-convention": {
        "Key": "string.naming-convention",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Naming Convention",
        "title": "Camel Case / Snake Case / Kebab Case / Naming Convention Converter Online",
        "desc": "Camel Case / Snake Case / Kebab Case / Naming Convention Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HelloWorld\u0022, \u0022helloWorld\u0022, \u0022HELLO_WORLD\u0022, \u0022hello_world\u0022, \u0022HELLO-WORLD\u0022, \u0022hello-world\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HelloWorld\u0022, \u0022helloWorld\u0022, \u0022HELLO_WORLD\u0022, \u0022hello_world\u0022, \u0022HELLO-WORLD\u0022, \u0022hello-world\u0022)",
        "label": {}
    },
    "string.camel-case": {
        "Key": "string.camel-case",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Camel Case",
        "title": "Camel Case (Pascal Case) Converter Online",
        "desc": "Camel Case (Pascal Case) Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HelloWorld\u0022, \u0022helloWorld\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HelloWorld\u0022, \u0022helloWorld\u0022)",
        "label": {
            "encStrUpperCamelCase": "UpperCamelCase",
            "encStrLowerCamelCase": "lowerCamelCase"
        }
    },
    "string.snake-case": {
        "Key": "string.snake-case",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Snake Case",
        "title": "Snake Case Converter Online",
        "desc": "Snake Case Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO_WORLD\u0022, \u0022hello_world\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO_WORLD\u0022, \u0022hello_world\u0022)",
        "label": {
            "encStrUpperSnakeCase": "UPPER_SNAKE_CASE",
            "encStrLowerSnakeCase": "lower_snake_case"
        }
    },
    "string.kebab-case": {
        "Key": "string.kebab-case",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Kebab Case",
        "title": "Kebab Case Converter Online",
        "desc": "Kebab Case Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO-WORLD\u0022, \u0022hello-world\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO-WORLD\u0022, \u0022hello-world\u0022)",
        "label": {
            "encStrUpperKebabCase": "UPPER-KEBAB-CASE",
            "encStrLowerKebabCase": "lower-kebab-case"
        }
    },
    "string.character-width": {
        "Key": "string.character-width",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Character Width (Half, Full)",
        "title": "Character Width (Half-width, Full-width) Converter Online",
        "desc": "Character Width (Half-width, Full-width) Converter. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022\\uff28\\uff45\\uff4c\\uff4c\\uff4f\\uff0c\\u3000\\uff57\\uff4f\\uff52\\uff4c\\uff44\\uff01\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022\\uff28\\uff45\\uff4c\\uff4c\\uff4f\\uff0c\\u3000\\uff57\\uff4f\\uff52\\uff4c\\uff44\\uff01\u0022)",
        "label": {
            "encStrHalfWidth": "Half Width",
            "encStrFullWidth": "Full Width"
        }
    },
    "string.letter-case": {
        "Key": "string.letter-case",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Letter Case (Upper, Lower, Swap, Capital)",
        "title": "Letter Case (Upper-case, Lower-case) Converter Online",
        "desc": "Letter Case (Upper-case, Lower-case) Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO, WORLD!\u0022, \u0022hello, world!\u0022, \u0022hELLO, WORLD!\u0022, \u0022Hello, World!\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022HELLO, WORLD!\u0022, \u0022hello, world!\u0022, \u0022hELLO, WORLD!\u0022, \u0022Hello, World!\u0022)",
        "label": {
            "encStrUpperCase": "Upper Case",
            "encStrLowerCase": "Lower Case",
            "encStrSwapCase": "Swap Case",
            "encStrCapitalize": "Capitalize"
        }
    },
    "string.text-initials": {
        "Key": "string.text-initials",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Text Initials",
        "title": "Initials Text Converter Online",
        "desc": "Initials Text Converter. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Hw\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Hw\u0022)",
        "label": {
            "encStrInitials": "Initials"
        }
    },
    "string.text-reverse": {
        "Key": "string.text-reverse",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Text Reverse",
        "title": "Reverse Text Converter Online",
        "desc": "Reverse Text Converter. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022!dlrow ,olleH\u0022)",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 \u003C=\u003E \u0022!dlrow ,olleH\u0022)",
        "label": {
            "encStrReverse": "Reverse"
        }
    },
    "string.unicode-normalization": {
        "Key": "string.unicode-normalization",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Unicode Normalization",
        "title": "Unicode Normalization (NFC, NFKC, NFD, NFKD) Converter Online",
        "desc": "Unicode Normalization (NFC, NFKC, NFD, NFKD) Converter.",
        "tooltip": "Please input converting text here.",
        "label": {
            "encStrUnicodeNFC": "Unicode NFC",
            "encStrUnicodeNFKC": "Unicode NFKC",
            "decStrUnicodeNFC": "Unicode NFD",
            "decStrUnicodeNFKC": "Unicode NFKD"
        }
    },
    "string.line-sort": {
        "Key": "string.line-sort",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Line Sort",
        "title": "Text Line Sorter (Asc, Desc, Reverse) Online",
        "desc": "Text Line Sorter (Asc, Desc, Reverse).",
        "tooltip": "Please input multi-line text here.",
        "label": {
            "encStrLineSort": "Line Sort",
            "encStrLineSort.option.order": "Order",
            "encStrLineSort.option.order.asc": "Ascending",
            "encStrLineSort.option.order.desc": "Descending",
            "encStrLineSort.option.order.reverse": "Reverse"
        }
    },
    "string.line-unique": {
        "Key": "string.line-unique",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Line Unique",
        "title": "Text Line Duplicates Remover Online",
        "desc": "Text Line Duplicates Remover.",
        "tooltip": "Please input multi-line text here.",
        "label": {
            "encStrLineUnique": "Line Unique"
        }
    },
    "number.all": {
        "Key": "number.all",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Number - ALL",
        "title": "Number Converter Online (Binary / Octal / Decimal / Hexadecimal / English / Japanese)",
        "desc": "Number converter. e.g. Binary numbers / Octal numbers / Decimal numbers / Hexadecimal numbers / English words numerals / Japanese numerals / and many other formats!",
        "tooltip": "Please input converting number here. (e.g. Dec: \u00221234567890\u0022, \u00221,234,567,890\u0022 / Bin: \u00221001001100101100000001011010010\u0022 / Oct: \u002211145401322\u0022 / Hex: \u0022499602d2\u0022 / EN: \u0022One Billion Two Hundred Thirty-Four Million Five Hundred Sixty-Seven Thousand Eight Hundred Ninety\u0022 / JP: \u0022\\u5341\\u4e8c\\u5104\\u4e09\\u5343\\u56db\\u767e\\u4e94\\u5341\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u5341\u0022, \u0022\\u62fe\\u5f10\\u5104\\u53c2\\u5343\\u56db\\u767e\\u4e94\\u62fe\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u62fe\u0022)",
        "label": {}
    },
    "number.dec": {
        "Key": "number.dec",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Decimal Numbers",
        "title": "Decimal Numbers Converter Online",
        "desc": "Decimal numbers converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u00221234567890\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u00221234567890\u0022)",
        "label": {
            "encNumDec": "Num to Dec",
            "decNumDec": "Num from Dec"
        }
    },
    "number.bin": {
        "Key": "number.bin",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Binary Numbers",
        "title": "Binary Numbers Converter Online",
        "desc": "Binary numbers converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u00221001001100101100000001011010010\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u00221001001100101100000001011010010\u0022)",
        "label": {
            "encNumBin": "Num to Bin",
            "decNumBin": "Num from Bin"
        }
    },
    "number.oct": {
        "Key": "number.oct",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Octal Numbers",
        "title": "Octal Numbers Converter Online",
        "desc": "Octal numbers converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u002211145401322\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u002211145401322\u0022)",
        "label": {
            "encNumOct": "Num to Oct",
            "decNumOct": "Num from Oct"
        }
    },
    "number.hex": {
        "Key": "number.hex",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Hexadecimal Numbers",
        "title": "Hexadecimal Numbers Converter Online",
        "desc": "Hexadecimal numbers converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u0022499602d2\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u0022499602d2\u0022)",
        "label": {
            "encNumHex": "Num to Hex",
            "decNumHex": "Num from Hex"
        }
    },
    "number.english": {
        "Key": "number.english",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "English Numerals",
        "title": "English Words Numerals Converter Online",
        "desc": "English words numerals converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u0022One Billion Two Hundred Thirty-Four Million Five Hundred Sixty-Seven Thousand Eight Hundred Ninety\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u0022One Billion Two Hundred Thirty-Four Million Five Hundred Sixty-Seven Thousand Eight Hundred Ninety\u0022)",
        "label": {
            "encNumEnShortScale": "Num to English",
            "encNumEnShortScale.option.fractionalPartNotation": "Fractional Part Notation",
            "encNumEnShortScale.option.fractionalPartNotation.default": "Numeral words",
            "encNumEnShortScale.option.fractionalPartNotation.fraction": "Fraction",
            "encNumEnShortScale.option.system": "System",
            "encNumEnShortScale.option.system.default": "CW4EN",
            "encNumEnShortScale.option.system.cw": "Conway-Wechsler",
            "decNumEnShortScale": "Num from English"
        }
    },
    "number.japanese": {
        "Key": "number.japanese",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Kanji Numerals",
        "title": "Japanese Kanji Numerals Converter Online",
        "desc": "Japanese Kanji numerals converter. e.g. \u00221234567890\u0022 \u003C=\u003E \u0022\\u5341\\u4e8c\\u5104\\u4e09\\u5343\\u56db\\u767e\\u4e94\\u5341\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u5341\u0022, \u0022\\u62fe\\u5f10\\u5104\\u53c2\\u5343\\u56db\\u767e\\u4e94\\u62fe\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u62fe\u0022",
        "tooltip": "Please input converting number here. (e.g. \u00221234567890\u0022 \u003C=\u003E \u0022\\u5341\\u4e8c\\u5104\\u4e09\\u5343\\u56db\\u767e\\u4e94\\u5341\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u5341\u0022, \u0022\\u62fe\\u5f10\\u5104\\u53c2\\u5343\\u56db\\u767e\\u4e94\\u62fe\\u516d\\u4e07\\u4e03\\u5343\\u516b\\u767e\\u4e5d\\u62fe\u0022)",
        "label": {
            "encNumJP": "Num to Kanji",
            "encNumJPDaiji": "Num to Kanji Daiji",
            "decNumJP": "Num from Kanji"
        }
    },
    "date.all": {
        "Key": "date.all",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Date - ALL",
        "title": "Date Time Converter Online (UNIX Time / ISO8601 Date / RFC2822 Date / ctime)",
        "desc": "Date Time converter. e.g. UNIX Time / ISO8601 Date / RFC2822 Date / and many other formats!",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022 / ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 / RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022)",
        "label": {}
    },
    "date.unix-time": {
        "Key": "date.unix-time",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "UNIX Time",
        "title": "UNIX Time (POSIX Time) Converter Online",
        "desc": "UNIX time (POSIX time) converter. e.g. ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E UNIX Time: \u0022444972896789\u0022",
        "tooltip": "Please input converting date here. (e.g. ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E UNIX Time: \u0022444972896789\u0022)",
        "label": {
            "encDateUnixTime": "UNIX Time [ms]"
        }
    },
    "date.w3cdtf": {
        "Key": "date.w3cdtf",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "W3C-DTF Date",
        "title": "W3C-DTF Date Converter Online",
        "desc": "W3C-DTF date converter. e.g. UNIX Time: \u0022444972896789\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E W3C-DTF: \u00221984-02-07T12:34:56.789\u002B09:00\u0022",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E W3C-DTF: \u00221984-02-07T12:34:56.789\u002B09:00\u0022)",
        "label": {
            "encDateW3CDTF": "W3C-DTF Date"
        }
    },
    "date.iso8601": {
        "Key": "date.iso8601",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "ISO8601 Date",
        "title": "ISO8601 Date Converter Online",
        "desc": "ISO8601 date converter. e.g. UNIX Time: \u0022444972896789\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022, RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022 =\u003E ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022)",
        "label": {
            "encDateISO8601": "ISO8601 Date",
            "encDateISO8601.option.decimalMark": "Decimal Mark",
            "encDateISO8601.option.decimalMark.dot": "Dot (.)",
            "encDateISO8601.option.decimalMark.comma": "Comma (,)",
            "encDateISO8601Ext": "ISO8601 Date (Extend)",
            "encDateISO8601Ext.option.decimalMark": "Decimal Mark",
            "encDateISO8601Ext.option.decimalMark.dot": "Dot (.)",
            "encDateISO8601Ext.option.decimalMark.comma": "Comma (,)",
            "encDateISO8601Week": "ISO8601 Date (Week)",
            "encDateISO8601Week.option.decimalMark": "Decimal Mark",
            "encDateISO8601Week.option.decimalMark.dot": "Dot (.)",
            "encDateISO8601Week.option.decimalMark.comma": "Comma (,)",
            "encDateISO8601Ordinal": "ISO8601 Date (Ordinal)",
            "encDateISO8601Ordinal.option.decimalMark": "Decimal Mark",
            "encDateISO8601Ordinal.option.decimalMark.dot": "Dot (.)",
            "encDateISO8601Ordinal.option.decimalMark.comma": "Comma (,)"
        }
    },
    "date.rfc2822": {
        "Key": "date.rfc2822",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "RFC2822 Date",
        "title": "RFC2822 Date Converter Online",
        "desc": "RFC2822 date converter. e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E RFC2822: \u0022Tue, 07 Feb 1984 12:34:56 JST\u0022)",
        "label": {
            "encDateRFC2822": "RFC2822 Date"
        }
    },
    "date.ctime": {
        "Key": "date.ctime",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "ctime Date",
        "title": "ctime Date Converter Online",
        "desc": "ctime date converter. e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E ctime: \u0022Tue Feb 07 12:34:56 1984\u0022",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E ctime: \u0022Tue Feb 07 12:34:56 1984\u0022)",
        "label": {
            "encDateCTime": "ctime Date"
        }
    },
    "date.japanese-era": {
        "Key": "date.japanese-era",
        "useOe": false,
        "useNl": false,
        "useTz": true,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Japanese Era",
        "title": "Japanese Era Date Converter Online",
        "desc": "Japanese Era date converter. e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E Japanese Era: \u0022\\u662d\\u548c59\\u5e7402\\u670807\\u65e503\\u664234\\u520656.789\\u79d2\u0022",
        "tooltip": "Please input converting date here. (e.g. UNIX Time: \u0022444972896789\u0022, ISO8601: \u00221984-02-07T12:34:56,789\u002B09:00\u0022 =\u003E Japanese Era: \u0022\\u662d\\u548c59\\u5e7402\\u670807\\u65e503\\u664234\\u520656.789\\u79d2\u0022)",
        "label": {
            "encDateJapaneseEra": "Japanese Era"
        }
    },
    "color.all": {
        "Key": "color.all",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Color - ALL",
        "title": "Color Converter Online (RGB / HSL / HSV / CMYK)",
        "desc": "Color converter. e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022)",
        "label": {}
    },
    "color.name": {
        "Key": "color.name",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Color Name",
        "title": "Color Name Converter Online",
        "desc": "Color name converter. e.g. \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022red\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022red\u0022)",
        "label": {
            "encColorName": "Color Name"
        }
    },
    "color.rgb": {
        "Key": "color.rgb",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "RGB Color",
        "title": "RGB Color Converter Online",
        "desc": "RGB color converter. e.g. \u0022red\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022red\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022)",
        "label": {
            "encColorRGBHex": "RGB Color (Hex)",
            "encColorRGBFn": "RGB Color",
            "encColorRGBFn.option.notation": "Notation",
            "encColorRGBFn.option.notation.percentage": "Percentage [0%..100%]",
            "encColorRGBFn.option.notation.number": "Number [0..255]"
        }
    },
    "color.hsl": {
        "Key": "color.hsl",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "HSL Color",
        "title": "HSL Color Converter Online",
        "desc": "HSL color converter. e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022hsl(0 100% 50%)\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsv(0 100% 100%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022hsl(0 100% 50%)\u0022)",
        "label": {
            "encColorHSLFn": "HSL Color"
        }
    },
    "color.hsv": {
        "Key": "color.hsv",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "HSV Color",
        "title": "HSV Color Converter Online",
        "desc": "HSV color converter. e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022hsv(0 100% 100%)\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022device-cmyk(0% 100% 100% 0%)\u0022 =\u003E \u0022hsv(0 100% 100%)\u0022)",
        "label": {
            "encColorHSVFn": "HSV Color"
        }
    },
    "color.cmyk": {
        "Key": "color.cmyk",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "CMYK Color",
        "title": "CMYK Color Converter Online",
        "desc": "CMYK color converter. e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022 =\u003E \u0022device-cmyk(0% 100% 100% 0%)\u0022",
        "tooltip": "Please input converting color here. (e.g. \u0022red\u0022, \u0022#ff0000\u0022, \u0022rgb(255 0 0)\u0022, \u0022hsl(0 100% 50%)\u0022, \u0022hsv(0 100% 100%)\u0022 =\u003E \u0022device-cmyk(0% 100% 100% 0%)\u0022)",
        "label": {
            "encColorCMYKFn": "CMYK Color"
        }
    },
    "cipher.all": {
        "Key": "cipher.all",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Cipher - ALL",
        "title": "Cipher Encrypter / Decrypter Online (Caesar / ROT)",
        "desc": "Cipher encrypter / decrypter. e.g. Caesar / ROT / and many other formats!",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022)",
        "label": {}
    },
    "cipher.caesar": {
        "Key": "cipher.caesar",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Caesar Cipher",
        "title": "Caesar Cipher Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "Caesar Cipher encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Ebiil, tloia!\u0022)",
        "label": {
            "encCipherCaesar": "Caesar",
            "decCipherCaesar": "Caesar",
            "encCipherCaesar.option.shift": "Shift",
            "encCipherCaesar.option.shift.b42": "-42",
            "encCipherCaesar.option.shift.b41": "-41",
            "encCipherCaesar.option.shift.b40": "-40",
            "encCipherCaesar.option.shift.b39": "-39",
            "encCipherCaesar.option.shift.b38": "-38",
            "encCipherCaesar.option.shift.b37": "-37",
            "encCipherCaesar.option.shift.b36": "-36",
            "encCipherCaesar.option.shift.b35": "-35",
            "encCipherCaesar.option.shift.b34": "-34",
            "encCipherCaesar.option.shift.b33": "-33",
            "encCipherCaesar.option.shift.b32": "-32",
            "encCipherCaesar.option.shift.b31": "-31",
            "encCipherCaesar.option.shift.b30": "-30",
            "encCipherCaesar.option.shift.b29": "-29",
            "encCipherCaesar.option.shift.b28": "-28",
            "encCipherCaesar.option.shift.b27": "-27",
            "encCipherCaesar.option.shift.b26": "-26",
            "encCipherCaesar.option.shift.b25": "-25 (A -\u003E B)",
            "encCipherCaesar.option.shift.b24": "-24 (A -\u003E C)",
            "encCipherCaesar.option.shift.b23": "-23 (A -\u003E D)",
            "encCipherCaesar.option.shift.b22": "-22 (A -\u003E E)",
            "encCipherCaesar.option.shift.b21": "-21 (A -\u003E F)",
            "encCipherCaesar.option.shift.b20": "-20 (A -\u003E G)",
            "encCipherCaesar.option.shift.b19": "-19 (A -\u003E H)",
            "encCipherCaesar.option.shift.b18": "-18 (A -\u003E I)",
            "encCipherCaesar.option.shift.b17": "-17 (A -\u003E J)",
            "encCipherCaesar.option.shift.b16": "-16 (A -\u003E K)",
            "encCipherCaesar.option.shift.b15": "-15 (A -\u003E L)",
            "encCipherCaesar.option.shift.b14": "-14 (A -\u003E M)",
            "encCipherCaesar.option.shift.b13": "-13 (A -\u003E N)",
            "encCipherCaesar.option.shift.b12": "-12 (A -\u003E O)",
            "encCipherCaesar.option.shift.b11": "-11 (A -\u003E P)",
            "encCipherCaesar.option.shift.b10": "-10 (A -\u003E Q)",
            "encCipherCaesar.option.shift.b9": "-9 (A -\u003E R)",
            "encCipherCaesar.option.shift.b8": "-8 (A -\u003E S)",
            "encCipherCaesar.option.shift.b7": "-7 (A -\u003E T)",
            "encCipherCaesar.option.shift.b6": "-6 (A -\u003E U)",
            "encCipherCaesar.option.shift.b5": "-5 (A -\u003E V)",
            "encCipherCaesar.option.shift.b4": "-4 (A -\u003E W)",
            "encCipherCaesar.option.shift.b3": "-3 (A -\u003E X)",
            "encCipherCaesar.option.shift.b2": "-2 (A -\u003E Y)",
            "encCipherCaesar.option.shift.b1": "-1 (A -\u003E Z)",
            "encCipherCaesar.option.shift.1": "1 (A -\u003E B)",
            "encCipherCaesar.option.shift.2": "2 (A -\u003E C)",
            "encCipherCaesar.option.shift.3": "3 (A -\u003E D)",
            "encCipherCaesar.option.shift.4": "4 (A -\u003E E)",
            "encCipherCaesar.option.shift.5": "5 (A -\u003E F)",
            "encCipherCaesar.option.shift.6": "6 (A -\u003E G)",
            "encCipherCaesar.option.shift.7": "7 (A -\u003E H)",
            "encCipherCaesar.option.shift.8": "8 (A -\u003E I)",
            "encCipherCaesar.option.shift.9": "9 (A -\u003E J)",
            "encCipherCaesar.option.shift.10": "10 (A -\u003E K)",
            "encCipherCaesar.option.shift.11": "11 (A -\u003E L)",
            "encCipherCaesar.option.shift.12": "12 (A -\u003E M)",
            "encCipherCaesar.option.shift.13": "13 (A -\u003E N)",
            "encCipherCaesar.option.shift.14": "14 (A -\u003E O)",
            "encCipherCaesar.option.shift.15": "15 (A -\u003E P)",
            "encCipherCaesar.option.shift.16": "16 (A -\u003E Q)",
            "encCipherCaesar.option.shift.17": "17 (A -\u003E R)",
            "encCipherCaesar.option.shift.18": "18 (A -\u003E S)",
            "encCipherCaesar.option.shift.19": "19 (A -\u003E T)",
            "encCipherCaesar.option.shift.20": "20 (A -\u003E U)",
            "encCipherCaesar.option.shift.21": "21 (A -\u003E V)",
            "encCipherCaesar.option.shift.22": "22 (A -\u003E W)",
            "encCipherCaesar.option.shift.23": "23 (A -\u003E X)",
            "encCipherCaesar.option.shift.24": "24 (A -\u003E Y)",
            "encCipherCaesar.option.shift.25": "25 (A -\u003E Z)",
            "encCipherCaesar.option.shift.26": "26",
            "encCipherCaesar.option.shift.27": "27",
            "encCipherCaesar.option.shift.28": "28",
            "encCipherCaesar.option.shift.29": "29",
            "encCipherCaesar.option.shift.30": "30",
            "encCipherCaesar.option.shift.31": "31",
            "encCipherCaesar.option.shift.32": "32",
            "encCipherCaesar.option.shift.33": "33",
            "encCipherCaesar.option.shift.34": "34",
            "encCipherCaesar.option.shift.35": "35",
            "encCipherCaesar.option.shift.36": "36",
            "encCipherCaesar.option.shift.37": "37",
            "encCipherCaesar.option.shift.38": "38",
            "encCipherCaesar.option.shift.39": "39",
            "encCipherCaesar.option.shift.40": "40",
            "encCipherCaesar.option.shift.41": "41",
            "encCipherCaesar.option.shift.42": "42",
            "decCipherCaesar.option.shift": "Shift",
            "decCipherCaesar.option.shift.b42": "-42",
            "decCipherCaesar.option.shift.b41": "-41",
            "decCipherCaesar.option.shift.b40": "-40",
            "decCipherCaesar.option.shift.b39": "-39",
            "decCipherCaesar.option.shift.b38": "-38",
            "decCipherCaesar.option.shift.b37": "-37",
            "decCipherCaesar.option.shift.b36": "-36",
            "decCipherCaesar.option.shift.b35": "-35",
            "decCipherCaesar.option.shift.b34": "-34",
            "decCipherCaesar.option.shift.b33": "-33",
            "decCipherCaesar.option.shift.b32": "-32",
            "decCipherCaesar.option.shift.b31": "-31",
            "decCipherCaesar.option.shift.b30": "-30",
            "decCipherCaesar.option.shift.b29": "-29",
            "decCipherCaesar.option.shift.b28": "-28",
            "decCipherCaesar.option.shift.b27": "-27",
            "decCipherCaesar.option.shift.b26": "-26",
            "decCipherCaesar.option.shift.b25": "-25 (A \u003C- B)",
            "decCipherCaesar.option.shift.b24": "-24 (A \u003C- C)",
            "decCipherCaesar.option.shift.b23": "-23 (A \u003C- D)",
            "decCipherCaesar.option.shift.b22": "-22 (A \u003C- E)",
            "decCipherCaesar.option.shift.b21": "-21 (A \u003C- F)",
            "decCipherCaesar.option.shift.b20": "-20 (A \u003C- G)",
            "decCipherCaesar.option.shift.b19": "-19 (A \u003C- H)",
            "decCipherCaesar.option.shift.b18": "-18 (A \u003C- I)",
            "decCipherCaesar.option.shift.b17": "-17 (A \u003C- J)",
            "decCipherCaesar.option.shift.b16": "-16 (A \u003C- K)",
            "decCipherCaesar.option.shift.b15": "-15 (A \u003C- L)",
            "decCipherCaesar.option.shift.b14": "-14 (A \u003C- M)",
            "decCipherCaesar.option.shift.b13": "-13 (A \u003C- N)",
            "decCipherCaesar.option.shift.b12": "-12 (A \u003C- O)",
            "decCipherCaesar.option.shift.b11": "-11 (A \u003C- P)",
            "decCipherCaesar.option.shift.b10": "-10 (A \u003C- Q)",
            "decCipherCaesar.option.shift.b9": "-9 (A \u003C- R)",
            "decCipherCaesar.option.shift.b8": "-8 (A \u003C- S)",
            "decCipherCaesar.option.shift.b7": "-7 (A \u003C- T)",
            "decCipherCaesar.option.shift.b6": "-6 (A \u003C- U)",
            "decCipherCaesar.option.shift.b5": "-5 (A \u003C- V)",
            "decCipherCaesar.option.shift.b4": "-4 (A \u003C- W)",
            "decCipherCaesar.option.shift.b3": "-3 (A \u003C- X)",
            "decCipherCaesar.option.shift.b2": "-2 (A \u003C- Y)",
            "decCipherCaesar.option.shift.b1": "-1 (A \u003C- Z)",
            "decCipherCaesar.option.shift.1": "1 (A \u003C- B)",
            "decCipherCaesar.option.shift.2": "2 (A \u003C- C)",
            "decCipherCaesar.option.shift.3": "3 (A \u003C- D)",
            "decCipherCaesar.option.shift.4": "4 (A \u003C- E)",
            "decCipherCaesar.option.shift.5": "5 (A \u003C- F)",
            "decCipherCaesar.option.shift.6": "6 (A \u003C- G)",
            "decCipherCaesar.option.shift.7": "7 (A \u003C- H)",
            "decCipherCaesar.option.shift.8": "8 (A \u003C- I)",
            "decCipherCaesar.option.shift.9": "9 (A \u003C- J)",
            "decCipherCaesar.option.shift.10": "10 (A \u003C- K)",
            "decCipherCaesar.option.shift.11": "11 (A \u003C- L)",
            "decCipherCaesar.option.shift.12": "12 (A \u003C- M)",
            "decCipherCaesar.option.shift.13": "13 (A \u003C- N)",
            "decCipherCaesar.option.shift.14": "14 (A \u003C- O)",
            "decCipherCaesar.option.shift.15": "15 (A \u003C- P)",
            "decCipherCaesar.option.shift.16": "16 (A \u003C- Q)",
            "decCipherCaesar.option.shift.17": "17 (A \u003C- R)",
            "decCipherCaesar.option.shift.18": "18 (A \u003C- S)",
            "decCipherCaesar.option.shift.19": "19 (A \u003C- T)",
            "decCipherCaesar.option.shift.20": "20 (A \u003C- U)",
            "decCipherCaesar.option.shift.21": "21 (A \u003C- V)",
            "decCipherCaesar.option.shift.22": "22 (A \u003C- W)",
            "decCipherCaesar.option.shift.23": "23 (A \u003C- X)",
            "decCipherCaesar.option.shift.24": "24 (A \u003C- Y)",
            "decCipherCaesar.option.shift.25": "25 (A \u003C- Z)",
            "decCipherCaesar.option.shift.26": "26",
            "decCipherCaesar.option.shift.27": "27",
            "decCipherCaesar.option.shift.28": "28",
            "decCipherCaesar.option.shift.29": "29",
            "decCipherCaesar.option.shift.30": "30",
            "decCipherCaesar.option.shift.31": "31",
            "decCipherCaesar.option.shift.32": "32",
            "decCipherCaesar.option.shift.33": "33",
            "decCipherCaesar.option.shift.34": "34",
            "decCipherCaesar.option.shift.35": "35",
            "decCipherCaesar.option.shift.36": "36",
            "decCipherCaesar.option.shift.37": "37",
            "decCipherCaesar.option.shift.38": "38",
            "decCipherCaesar.option.shift.39": "39",
            "decCipherCaesar.option.shift.40": "40",
            "decCipherCaesar.option.shift.41": "41",
            "decCipherCaesar.option.shift.42": "42"
        }
    },
    "cipher.rot13": {
        "Key": "cipher.rot13",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "ROT13",
        "title": "ROT13 Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "ROT13 encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world 123!\u0022 =\u003E \u0022Uryyb, jbeyq 123!\u0022)",
        "label": {
            "encCipherROT13": "ROT13 (A-Z)",
            "decCipherROT13": "ROT13 (A-Z)"
        }
    },
    "cipher.rot18": {
        "Key": "cipher.rot18",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "ROT18",
        "title": "ROT18 Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "ROT18 encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world 123!\u0022 =\u003E \u0022Uryyb, jbeyq 678!\u0022)",
        "label": {
            "encCipherROT18": "ROT18 (A-Z, 0-9)",
            "decCipherROT18": "ROT18 (A-Z, 0-9)"
        }
    },
    "cipher.rot47": {
        "Key": "cipher.rot47",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "ROT47",
        "title": "ROT47 Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "ROT47 encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world 123!\u0022 =\u003E \u0022w6==@[ H@C=5 \u0060abP\u0022)",
        "label": {
            "encCipherROT47": "ROT47 (!-~)",
            "decCipherROT47": "ROT47 (!-~)"
        }
    },
    "cipher.jis-keyboard": {
        "Key": "cipher.jis-keyboard",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "JIS Keyboard",
        "title": "JIS Keyboard Converter Online",
        "desc": "JIS Keyboard encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022ntt\u0022 =\u003E \u0022\\u307F\\u304B\\u304B\u0022)",
        "label": {
            "encCipherJisKeyboard": "JIS Keyboard",
            "encCipherJisKeyboard.option.mode": "Mode",
            "encCipherJisKeyboard.option.mode.lenient": "Lenient",
            "encCipherJisKeyboard.option.mode.strict": "Strict"
        }
    },
    "cipher.enigma": {
        "Key": "cipher.enigma",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Enigma",
        "title": "Enigma Machine Simulator Online",
        "desc": "Enigma encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Kcubr, kidkn!\u0022)",
        "label": {
            "encCipherEnigma": "Enigma",
            "decCipherEnigma": "Enigma",
            "encCipherEnigma.option.machine": "Machine",
            "encCipherEnigma.option.wheels": "Wheel order",
            "encCipherEnigma.option.rings": "Ring setting",
            "encCipherEnigma.option.positions": "Position setting",
            "encCipherEnigma.option.plugboard": "Plugboard wiring",
            "encCipherEnigma.option.plugboard.tooltip": "e.g. AT BL DF GJ HM NW OP QY RZ VX",
            "encCipherEnigma.option.uhr": "Uhr",
            "encCipherEnigma.option.ukwd": "UKW-D wiring",
            "encCipherEnigma.option.ukwd.tooltip": "e.g. AQ BG CK DI EL FX HZ MW NV OT PU RS",
            "decCipherEnigma.option.machine": "Machine",
            "decCipherEnigma.option.wheels": "Wheel order",
            "decCipherEnigma.option.rings": "Ring setting",
            "decCipherEnigma.option.positions": "Position setting",
            "decCipherEnigma.option.plugboard": "Plugboard wiring",
            "decCipherEnigma.option.plugboard.tooltip": "e.g. AT BL DF GJ HM NW OP QY RZ VX",
            "decCipherEnigma.option.uhr": "Uhr",
            "decCipherEnigma.option.ukwd": "UKW-D wiring",
            "decCipherEnigma.option.ukwd.tooltip": "e.g. AQ BG CK DI EL FX HZ MW NV OT PU RS"
        }
    },
    "cipher.scytale": {
        "Key": "cipher.scytale",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Scytale Cipher",
        "title": "Scytale Cipher Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "Scytale Cipher encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Hweolrllod,! \u0022)",
        "label": {
            "encCipherScytale": "Scytale",
            "decCipherScytale": "Scytale",
            "encCipherScytale.option.key": "Max chars per lap",
            "decCipherScytale.option.key": "Max chars per lap"
        }
    },
    "cipher.rail-fence": {
        "Key": "cipher.rail-fence",
        "useOe": false,
        "useNl": false,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": true,
        "method": "Rail Fence Cipher",
        "title": "Rail Fence Cipher Encrypter / Decrypter, Encoder / Decoder, Solver, Translator Online",
        "desc": "Rail Fence Cipher encrypter / decrypter.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022Hlo ol!el,wrd\u0022)",
        "label": {
            "encCipherRailFence": "Rail Fence",
            "decCipherRailFence": "Rail Fence",
            "encCipherRailFence.option.key": "Rails",
            "decCipherRailFence.option.key": "Rails"
        }
    },
    "hash.all": {
        "Key": "hash.all",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "Hash - ALL",
        "title": "Hash Value Calculator Online (MD2 / MD5 / SHA-1 / SHA-256 / SHA-384 / SHA-512 / CRC32)",
        "desc": "Hash value calculator. e.g. MD2 / MD5 / SHA-1 / SHA-256 / SHA-384 / SHA-512 / CRC32 / and many other formats!",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022)",
        "label": {}
    },
    "hash.md2": {
        "Key": "hash.md2",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "MD2",
        "title": "MD2 Hash Value Calculator Online",
        "desc": "MD2 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u00228cca0e965edd0e223b744f9cedf8e141\u0022)",
        "label": {
            "encHashMD2": "MD2"
        }
    },
    "hash.md5": {
        "Key": "hash.md5",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "MD5",
        "title": "MD5 Hash Value Calculator Online",
        "desc": "MD5 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u00226cd3556deb0da54bca060b4c39479839\u0022)",
        "label": {
            "encHashMD5": "MD5"
        }
    },
    "hash.sha1": {
        "Key": "hash.sha1",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "SHA-1",
        "title": "SHA1 Hash Value Calculator Online",
        "desc": "SHA1 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022943a702d06f34599aee1f8da8ef9f7296031d699\u0022)",
        "label": {
            "encHashSHA1": "SHA-1"
        }
    },
    "hash.sha256": {
        "Key": "hash.sha256",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "SHA-256",
        "title": "SHA256 Hash Value Calculator Online",
        "desc": "SHA256 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022315f5bdb76d078c43b8ac0064e4a0164612b1fce77c869345bfc94c75894edd3\u0022)",
        "label": {
            "encHashSHA256": "SHA-256"
        }
    },
    "hash.sha384": {
        "Key": "hash.sha384",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "SHA-384",
        "title": "SHA384 Hash Value Calculator Online",
        "desc": "SHA384 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u002255bc556b0d2fe0fce582ba5fe07baafff035653638c7ac0d5494c2a64c0bea1cc57331c7c12a45cdbca7f4c34a089eeb\u0022)",
        "label": {
            "encHashSHA384": "SHA-384"
        }
    },
    "hash.sha512": {
        "Key": "hash.sha512",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "SHA-512",
        "title": "SHA512 Hash Value Calculator Online",
        "desc": "SHA512 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022c1527cd893c124773d811911970c8fe6e857d6df5dc9226bd8a160614c0cd963a4ddea2b94bb7d36021ef9d865d5cea294a82dd49a0bb269f51f6e7a57f79421\u0022)",
        "label": {
            "encHashSHA512": "SHA-512"
        }
    },
    "hash.crc32": {
        "Key": "hash.crc32",
        "useOe": true,
        "useNl": true,
        "useTz": false,
        "hasEncoded": true,
        "hasDecoded": false,
        "method": "CRC32",
        "title": "CRC32 Hash Value Calculator Online",
        "desc": "CRC32 hash value calculator.",
        "tooltip": "Please input converting text here. (e.g. \u0022Hello, world!\u0022 =\u003E \u0022ebe6c6e6\u0022)",
        "label": {
            "encHashCRC32": "CRC32"
        }
    }
}
""";
    }
}
