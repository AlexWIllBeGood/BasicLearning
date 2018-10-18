
$(function(){
   initTable();
   initTable2();
});
function initTable(){
	var infoArray=[];
infoArray.push({Name:"Alex",Age:25,Job:"Engineer",Description:"Seeing someone"});
infoArray.push({Name:"Jason",Age:24,Job:"Sale",Description:"Divorced"});
infoArray.push({Name:"John",Age:25,Job:"ArtDesigner",Description:"Unknown"});
infoArray.push({Name:"Jack",Age:25,Job:"Engineer",Description:"Seeing someone"});
var demoList=$("#DemoList");
$.each(infoArray,function(index,item){
	var htmlString="<tr><td>"+index+"</td><td>"+item.Name+"</td><td>"+item.Age+"</td><td>"+item.Job+"</td><td>"+item.Description+"</td></tr>";
	demoList.append(htmlString);
})
}
function initTable2(){
		var infoArray=[];
infoArray.push({Name:"Alex",Age:25,Job:"Engineer",Description:"Seeing someone"});
infoArray.push({Name:"Jason",Age:24,Job:"Sale",Description:"Divorced"});
infoArray.push({Name:"John",Age:25,Job:"ArtDesigner",Description:"Unknown"});
infoArray.push({Name:"Jack",Age:25,Job:"Engineer",Description:"Seeing someone"});
	layui.use(['table','layer',],function(){
		var layer=layui.layer;
		var table=layui.table;
	    layer.load();
		table.render({
			elem: '#TableId'
    ,height: 300
    // ,url: '/demo/table/user/' //数据接口
    ,page: true //开启分页
    ,cols: [[ //表头
      {field: 'Name', title: '名称', width:"20%", sort: true}
      ,{field: 'Age', title: '年龄', width:"20%"}
      ,{field: 'Job', title: '工作', width:"20%", sort: true}
      ,{field: 'Description', title: '描述', width:"20%"} 
    ]],
    data:infoArray
		});
	});
}