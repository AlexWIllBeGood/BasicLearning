$(function(){
	var numberArray=[];
	var text="";
	//1\基础for循环
	for(var i=0;i<6;i++)
	{
		var employee={"name":"Employee"+i.toString(),"age":i.toString()};
		numberArray.push(employee)
	}
	//2\for in 
	for(x in numberArray)
	{
		//x为目标对象的属性
		//numberArray[x]为值
		console.log(numberArray[x];)
	}
	//3\while  do..while
	//4\Jquey  each
	$.each(numberArray,function(index,item){
		console.log("employee"+index+":Name:"+item.name+" Age:"+item.age);
	});

});