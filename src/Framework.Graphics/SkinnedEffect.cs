﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insma.Mxa.Framework.Graphics {
	public class SkinnedEffect : Effect, IEffectMatrices, IEffectLights, IEffectFog {
		public const int MaxBones = 72;
		
		public SkinnedEffect(GraphicsDevice device) : base(device, new byte[0]) { throw new NotImplementedException( ); }
		protected SkinnedEffect(SkinnedEffect cloneSource) : base(cloneSource) { throw new NotImplementedException( ); }

		public override Effect Clone( ) { throw new NotImplementedException( ); }
		public void EnableDefaultLighting( ) { throw new NotImplementedException( ); }
		public Matrix[] GetBoneTransforms(int count) { throw new NotImplementedException( ); }
		protected internal override void OnApply( ) { throw new NotImplementedException( ); }
		public void SetBoneTransforms(Matrix[] boneTransforms) { throw new NotImplementedException( ); }

		public float Alpha { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 AmbientLightColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 DiffuseColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight0 { get { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight1 { get { throw new NotImplementedException( ); } }
		public DirectionalLight DirectionalLight2 { get { throw new NotImplementedException( ); } }
		public Vector3 EmissiveColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 FogColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool FogEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogEnd { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float FogStart { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		bool IEffectLights.LightingEnabled { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public bool PreferPerPixelLighting { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix Projection { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Vector3 SpecularColor { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public float SpecularPower { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Texture2D Texture { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix View { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public int WeightsPerVertex { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
		public Matrix World { get { throw new NotImplementedException( ); } set { throw new NotImplementedException( ); } }
	}
}
