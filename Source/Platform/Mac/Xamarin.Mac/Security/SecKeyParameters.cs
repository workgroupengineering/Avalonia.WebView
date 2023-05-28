using System;
using Foundation;

namespace Security;

public class SecKeyParameters : DictionaryContainer
{
	private SecAccessControl _secAccessControl;

	[iOS(8, 0)]
	[Mac(10, 10)]
	public SecAccessControl AccessControl
	{
		get
		{
			return _secAccessControl;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_secAccessControl = value;
			SetNativeValue(SecAttributeKeys.AccessControlKey, value);
		}
	}

	public string? Label
	{
		get
		{
			return GetStringValue(SecAttributeKeys.LabelKey);
		}
		set
		{
			SetStringValue(SecAttributeKeys.LabelKey, value);
		}
	}

	public bool? IsPermanent
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.IsPermanentKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.IsPermanentKey, value);
		}
	}

	public NSData? ApplicationTag
	{
		get
		{
			return base.Dictionary[SecAttributeKeys.ApplicationTagKey] as NSData;
		}
		set
		{
			SetNativeValue(SecAttributeKeys.ApplicationTagKey, value);
		}
	}

	public int? EffectiveKeySize
	{
		get
		{
			return GetInt32Value(SecAttributeKeys.EffectiveKeySizeKey);
		}
		set
		{
			SetNumberValue(SecAttributeKeys.EffectiveKeySizeKey, value);
		}
	}

	public bool? CanEncrypt
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanEncryptKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanEncryptKey, value);
		}
	}

	public bool? CanDecrypt
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanDecryptKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanDecryptKey, value);
		}
	}

	public bool? CanDerive
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanDeriveKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanDeriveKey, value);
		}
	}

	public bool? CanSign
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanSignKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanSignKey, value);
		}
	}

	public bool? CanVerify
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanVerifyKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanVerifyKey, value);
		}
	}

	public bool? CanUnwrap
	{
		get
		{
			return GetBoolValue(SecAttributeKeys.CanUnwrapKey);
		}
		set
		{
			SetBooleanValue(SecAttributeKeys.CanUnwrapKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SecKeyParameters()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SecKeyParameters(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}