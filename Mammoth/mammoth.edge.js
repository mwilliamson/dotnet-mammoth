;
return function(data, callback) {
    var mammoth = module.exports;

    mammoth.convertToHtml({arrayBuffer: toArrayBuffer(data)})
        .then(function(result) {
            callback(null, result.value);
        }, callback);

    function toArrayBuffer(buffer) {
        var ab = new ArrayBuffer(buffer.length);
        var view = new Uint8Array(ab);
        for (var i = 0; i < buffer.length; ++i) {
            view[i] = buffer[i];
        }
        return ab;
    }
};