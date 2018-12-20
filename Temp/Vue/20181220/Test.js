$(function(){
    var testBodyRelated=new Vue({
    	el:'#testBody',
    	data:{
    		prolongue:"Alex",
    		count:0,
            tab:"",
    		tableData: [{
        myIndex: 6,
        date: '2016-05-02',
        name: '王小虎',
        address: '<i>上海市普陀区金沙江路 1518 弄</i>',
        products:["Apple","Orange","banana"]
      }, {
        myIndex: 7,
        date: '2016-05-04',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1517 弄'
      }, {
        myIndex: 8,
        date: '2016-05-01',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1519 弄'
      }, {
        myIndex: 9,
        date: '2016-05-03',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1516 弄'
      }]
    	},
    	methods:{
            countNumber:function(){
                this.count+=1;
            },
            handleEdit:function(index,obj){
                
               console.log("Edit 第"+index+"行的对象属性为"+this.traverse(obj));
            },
            handleDelete:function(){

            },
            traverse:function(obj){
                var attributeString="";
                for( i in obj)
                {
                    attributeString+=i;
                    attributeString+=":";
                    attributeString+=obj[i];
                    attributeString+="";
                }
                return attributeString;
            },
            indexMethod:function(obj){
                return obj+1;
            }
    	}
    });
});