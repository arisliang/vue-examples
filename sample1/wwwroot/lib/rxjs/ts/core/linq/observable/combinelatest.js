(function () {
    var o;
    var io;
    var so;
    var p;
    var r = Rx.Observable.combineLatest(o, io, p, so, function (vo, vio, vp, vso) { return ({ vo: vo, vio: vio, vp: vp, vso: vso }); });
    var rr = Rx.Observable.combineLatest([o, io, so, p], function (items) { return 5; });
});
