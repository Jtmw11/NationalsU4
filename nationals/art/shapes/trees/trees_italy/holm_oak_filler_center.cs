
singleton TSShapeConstructor(Holm_oak_filler_centerDae)
{
   baseShape = "./holm_oak_filler_center.dae";
   loadLights = "0";
};

function Holm_oak_filler_centerDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
