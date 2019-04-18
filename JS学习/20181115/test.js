$(function(){
	// function Rectangle(length1,width)
	// {
	// 	//this表示的是Rectangle new后的对象 相当于是
	// 	this.length1=length1;
	// 	this.width=width;
	// }
	// //lamda表达式中的快速执行和普通匿名函数的快速执行不相同
	// Rectangle.prototype=function(){
	// 	var area1=function(){return this.width*this.length1};
	// 	var area2=()=>{return this.width*this.length1};
	// 	return {area1:area1,area2:area2};
	// }();
 //    var rectangle=new Rectangle(10,20);
	// console.log(rectangle.area1());
	// console.log(rectangle.area2());

	//this关键字中所指代的对象
	obj={
		'birth':1993,
		'GetAge':function(){
			var $this=this;
		   return new Date().getFullYear()-this.birth;
		},
		'GetAge1':()=>{
			var $this=this;
		   return new Date().getFullYear()-this.birth;
		}
	}
	console.log(obj.GetAge());
	console.log(obj.GetAge1());
});