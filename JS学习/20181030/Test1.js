$(function(){

	//计数器困境：假如不申明全局变量就不能 获取到函数内部的值
	//闭包是可访问上一层函数作用域里变量的函数，即便上一层函数已经关闭。
	var add=(function(){
		var count=0;
		return function(){
			return count+=1;
		}
	})();
	add();
	add();
	add();
	console.log();
});