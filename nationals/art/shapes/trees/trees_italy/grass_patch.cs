
singleton TSShapeConstructor(Grass_patchDae)
{
   baseShape = "./grass_patch.dae";
};

function Grass_patchDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
