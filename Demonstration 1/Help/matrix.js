function Matrix()
{
	var _matrix = [[1, 0], [0, 1]];
	
	this.Assign = function(matrix)
	{
		_matrix = matrix;
	}
	
	this.Multiply(matrix)
	{
		for (var i = 0; i < 2; i++)
		{
			for (var j = 0; j < matrix.length/2; j++)
			{
				result[i][j] = _matrix[i][j]*matrix[j][i];
			}
		}
	}
	
	this.Value(row, col)
	{
		return _matrix[row][col];
	}
}
