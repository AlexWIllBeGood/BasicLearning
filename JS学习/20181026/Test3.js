$(function(){
	//JS 函数参数
    //显示参数
    function getSum(a,b)
    {
    	if(a==undefined){a=0;}
    	if(b==undefined){b=0;}
    	return a+b;
    }
    //另外一种默认值写法
    function getSum1(a,b)
    {
    	a=a||0;
    	b=b||0;
    	return a+b;
    }

    //隐式参数
    function getMax()
    {
        var i,max=arguments[0];
        for(i=0;i<arguments.length;i++)
        {
        	if(max<arguments[i])
        	{
        		max=arguments[i]
        	}
        }
        return max;
    }
    console.log(getSum());
    console.log(getSum1());

    console.log("max value:"+getMax(12,23,72,34,12,34,56));
    function getParams()
    {
       $.each(arguments,function(index,item){
       	   console.log("parameter"+index+":"+item);
       });
    }
    getParams(23,43,44,22,33,45,67);

    //函数闭包 计数器的困境：如果不声明全局变量的话 永远不能实现计数器 
    //b
    var add=(function()
    {
    	var count=0;
    	return function(){
    		return count+=1;
    	}
    })();
    console.log(add());
    console.log(add());
    console.log(add());
});