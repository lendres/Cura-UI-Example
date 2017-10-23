function Annotator(graphics)
{
	// Private fields.
	var _graphics			= graphics;
	var _color				= "#cc0000";
	var _stroke				= 2;
	var _fontsize			= 14;
	var _fontsizetext		= _fontsize + "px";
	var _font				= "arial,sans-serif";
	var _xlabelposition		= 5;
	var _fontgap			= 8;
	var _arrowsize			= 14;
	var _leaderxlength		= 15;
	var _leaderxbreak		= _xlabelposition-_fontgap-_leaderxlength;
	
	var _rotation			= [[1, 0], [0, 1]];
	
	this.Color = function(color)
	{
		_color = color;
		_graphics.setColor(_color);
	}

	this.Stroke = function(stroke)
	{
		_stroke = stroke;
		_graphics.setStroke(_stroke);
	}

	this.FontSize = function(fontsize)
	{
		_fontsize		= fontsize;
		_fontsizetext	= fontsize + "px";
		_graphics.setFont(_font, _fontsizetext, Font.BOLD);
	}

	this.XLabelPosition = function(xlabelposition)
	{
		_xlabelposition = xlabelposition;
		this.CalculateLeaderXBreak();
	}

	this.ArrowSize = function(arrowsize)
	{
		_arrowsize = arrowsize;
	}
	
	this.LeaderXLength = function(leaderxlength)
	{
		_leaderxlength = leaderxlength;
		this.CalculateLeaderXBreak();
	}
	
	this.CalculateLeaderXBreak = function()
	{
		_leaderxbreak = _xlabelposition-_fontgap-_leaderxlength;
	}

	this.InitializeGraphics = function()
	{
		_graphics.setColor(_color);
		_graphics.setStroke(_stroke);
		_graphics.setFont(_font, _fontsizetext, Font.BOLD);
	}
	
	this.DrawArrow = function(x_begin, y_begin, x_end, y_end)
	{
		var head	= [x_begin, y_begin];
		var tail	= [x_end, y_end];
		var xarrow	= _arrowsize;
		var yarrow	= xarrow/2;
		var pntend1	= [xarrow, +yarrow];
		var pntend2	= [xarrow, -yarrow];
		
		var theta = Math.atan((y_begin - y_end) / (x_end-x_begin));
		var rotmat = MakeRotation(theta);

		var pntend1a = Multiply(rotmat, pntend1);
		var pntend2a = Multiply(rotmat, pntend2);

		pntend1 = Add(head, pntend1a);
		pntend2 = Add(head, pntend2a);

		_graphics.drawLine(head[0], head[1], pntend1[0], pntend1[1]);
		_graphics.drawLine(head[0], head[1], pntend2[0], pntend2[1]);
		_graphics.drawLine(head[0], head[1], tail[0], tail[1]);
	}

	this.DrawHorLabel = function(text, x_begin, y)
	{
		this.DrawArrow(x_begin, y, _leaderxbreak, y);
		_graphics.drawLine(_leaderxbreak, y, _xlabelposition-_fontgap, y);
		_graphics.drawString(text, _xlabelposition, y-_fontsize/2);
	}
	
	this.DrawHorLabel2 = function(textline1, textline2, x_begin, y)
	{
		this.DrawArrow(x_begin, y, _leaderxbreak, y);
		_graphics.drawLine(_leaderxbreak, y, _xlabelposition-_fontgap, y);
		_graphics.drawString(textline1, _xlabelposition, y-1.1*_fontsize);
		_graphics.drawString(textline2, _xlabelposition, y+0.1*_fontsize);
	}
	
	this.DrawLeaderLabel = function(text, x_begin, y_begin, y_end)
	{
		this.DrawArrow(x_begin, y_begin, _leaderxbreak, y_end);
		_graphics.drawLine(_leaderxbreak, y_end, _xlabelposition-_fontgap, y_end);
		_graphics.drawString(text, _xlabelposition, y_end-_fontsize/2);
	}

	this.DrawLeaderLabel2 = function(textline1, textline2, x_begin, y_begin, y_end)
	{
		this.DrawArrow(x_begin, y_begin, _leaderxbreak, y_end);
		_graphics.drawLine(_leaderxbreak, y_end, _xlabelposition-_fontgap, y_end);
		_graphics.drawString(textline1, _xlabelposition, y_end-1.1*_fontsize);
		_graphics.drawString(textline2, _xlabelposition, y_end+0.1*_fontsize);
	}

}

function MakeRotation(theta)
{
	return [[Math.cos(theta), Math.sin(theta)], [-Math.sin(theta), Math.cos(theta)]];	
}

function Multiply(_matrix, matrix)
{
//	for (var i = 0; i < 2; i++)
//	{
//		for (var j = 0; j < matrix.length/2; j++)
//		{
//			result[i][j] = _matrix[i][j]*matrix[j][i];
//		}
//	}

	result = [_matrix[0][0]*matrix[0] + _matrix[0][1]*matrix[1], _matrix[1][0]*matrix[0] + _matrix[1][1]*matrix[1]];	
	return result;
}

function Subtract(_vector, vector)
{
	return [_vector[0]-vector[0], _vector[1]-vector[1]];
}

function Add(_vector, vector)
{
	return [_vector[0]+vector[0], _vector[1]+vector[1]];
}

function Deg2Rad(theta)
{
	return theta * Math.PI / 180;
}

function Rad2Deg(theta)
{
	return theta / Math.PI * 180;
}