$(function(){
	var tableData = [
        { "ItemName": "员工姓名","PositionIndex": 1 },
        { "ItemName": "证件号码","PositionIndex": 2 },
        { "ItemName": "员工状态","PositionIndex": 3 },
        { "ItemName": "应出勤天数","PositionIndex": 4 },
        { "ItemName": "实际出勤天数","PositionIndex": 5 },
        { "ItemName": "应发薪资","PositionIndex": 6 },
        { "ItemName": "应税薪资","PositionIndex": 7 },
        { "ItemName": "应扣薪资","PositionIndex": 8 },
        { "ItemName": "个税金额","PositionIndex": 9 },
        { "ItemName": "实发薪资","PositionIndex": 10 }
    ];
    function sortAsc(data) {
        var len = data.length;
        for (var i = 0; i < len; i++) {
            for (var j = 0; j < len - 1 - i; j++) {
                if (data[j].PositionIndex > data[j + 1].PositionIndex) {
                    var temp = data[j + 1];
                    data[j + 1] = data[j];
                    data[j] = temp;
                }
            }
        }
        var initIndex = 1;
        for (var i = 0; i < data.length; i++) {
            data[i].PositionIndex = initIndex++;
        }
        return data;
    }
    function TempShow(tempRows) {
        var result = "";
        for (var item in tempRows) {
            var temp = tempRows[item];
            var temp1 = temp.ItemName.replace('\r', "").replace('\n',"") + "-" + temp.PositionIndex
            result = result + temp1 + " ";
        }
        console.log(result);
    }
});