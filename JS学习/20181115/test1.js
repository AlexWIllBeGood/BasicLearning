(function(){
	var a=Number.MAX_VALUE+1;
	var b=Infinity;
	var c=b+1;
	console.log(a);
	console.log(b);
	console.log(c);

    var a=0.2-0.1;
    var b=0.3-0.2;
    console.log(a==b);
    var tempString="hello,world! 1,2,3,4";
    var reg=/\d+/g;
    var matchArray=tempString.match(reg);
    console.log(typeof(matchArray));
    console.log(matchArray instanceof Array);
    for(a in matchArray)
    {
    console.log(matchArray[a]);
    }
	})();
	