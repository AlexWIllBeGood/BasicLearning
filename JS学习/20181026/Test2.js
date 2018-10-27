//JS JSON对象和字符串转换
    function TestJsonObject(name,age)
    {
    	this.name=name;
    	this.age=age;
    }

    TestJsonObject.prototype=function(){
    	var getJsonString=function(){
    		return JSON.stringify(this);
    	};
        return {getJsonString:getJsonString};
    }();

    var test=new TestJsonObject("Alex",24);
    console.log(test.getJsonString());
    var jsonString="[{\"name\":\"jane\",\"age\":\"23\"},{\"name\":\"jerry\",\"age\":\"22\"}]";
    var objectList=JSON.parse(jsonString);
    $.each(objectList,function(index,item){
        console.log("object"+index+" name:"+item.name+" age:"+item.age);
    });
    
    var arrayPerson=[];
    for(var i=0;i<5;i++)
    {
        var emp=new TestJsonObject("employee"+i,20+i);
        arrayPerson.push(emp);
    }
    console.log(JSON.stringify(arrayPerson));