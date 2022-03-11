local M = {}

local function setAllLightsEnabled(group, value)
    for i = 0, group.obj:getCount(), 1 do
        local id = group.obj:idAt(i)
        local obj = scenetree.findObjectById(id)
        if obj and obj.obj:isSubClassOf('LightBase') then
            obj.obj:setLightEnabled( value )
        end
    end
end

local lastValue = nil

local function onUpdate()
    local tod = scenetree.tod
    if not tod then return end

    local value = false
    if tod.time > 0.21 and tod.time < 0.77 then
        value = true
    end

    if lastValue == value then return end
    lastValue = value

    if scenetree.harbour_lights then
      setAllLightsEnabled(scenetree.harbour_lights, value )
      setAllLightsEnabled(scenetree.helipad_lights, value )
    end
end

M.onUpdate = onUpdate

return M