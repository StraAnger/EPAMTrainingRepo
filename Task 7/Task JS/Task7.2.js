	function CalculateString(inputStr) {
		this._str = inputStr;
		console.log("Введена строка: " + this._str);
	}
	CalculateString.prototype.calc = function() {
		var result = 0,
			matchArr = [],
			searchPattern = /\-?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1}/ig;

		matchArr = this._str.match(searchPattern);

		if(matchArr[0]*1+"" !== "NaN") {
			result += matchArr[0]*1;
		}

		for(var i = 0; i < matchArr.length; i++) {
			switch(matchArr[i]) {
				case "+": result += matchArr[i+1] * 1; break;
				case "-": result -= matchArr[i+1] * 1; break;
				case "*": result *= matchArr[i+1] * 1; break;
				case "/": result /= matchArr[i+1] * 1; break;
				case "=": break;
				default: continue; break;
			}
		}

		return result;
	}