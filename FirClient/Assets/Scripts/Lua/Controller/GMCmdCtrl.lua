local BaseCtrl = require 'Controller.BaseCtrl'
local GMCmdCtrl = class("GMCmdCtrl", BaseCtrl)

function GMCmdCtrl:Execute(text)
	local gm_array = text:split(':')
	if string.len(gm_array[2]) == 0 then
		return
	end
	local content = gm_array[2]:split(' ')
	if #gm_array == 0 then
		self:ParseSingleCmd(gm_array[1])
	else
		self:ParseMultiCmd(gm_array[1], gm_array[2])
	end
	logError('GMCmdCtrl:Execute--->'..text)
end

function GMCmdCtrl:ParseSingleCmd(cmd)
	if cmd == "dump" then
		self.resMgr:TakeSnapshot()
	elseif cmd == 'diff' then
		self.resMgr:DiffSnapshot()
	elseif cmd == 'cldump' then
		self.resMgr:ClearSnapshot()
	end
end

function GMCmdCtrl:ParseMultiCmd(cmd, param)
	if cmd == "loadmap" then
	end
end

return GMCmdCtrl