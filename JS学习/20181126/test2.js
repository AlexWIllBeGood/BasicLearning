$(function(){
    function circle(r){
    	this.r=r;
    }
    circle.PI=3.14;
    circle.prototype.area=()=>{
    	return circle.PI*Math.pow(this.r,2);
    }
    var c=new circle(2);
    console.log(c.area());//结果为NaN 因为this.r为undefined
});