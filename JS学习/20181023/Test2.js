$(function(){
	//== ===进行判断
	a="123";
	b=123;
	console.log(a==b); //true
	console.log(a===b); //false
    //三元表达式
	function Capable(age){
		return age>18?"合格":"不合格";
	}
	console.log(Capable(22));
	//优秀的类似于switch的写法
	//深户 1
    ///城镇户口 2
    ///农村户口 3
    ///港澳台 4
    ///其他 5
	let residenceOptions={
		"1":()=>{console.log("深户")},
		"2":()=>{console.log("城镇户口")},
		"3":()=>{console.log("农村户口")},
		"4":()=>{console.log("港澳台")},
		"5":()=>{console.log("其他")}
	};
	let 
});