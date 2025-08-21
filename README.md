<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1298864)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# DevExpress Blazor Data Editors - Incorporate Google reCAPTCHA tool

This example incorporates Google reCAPTCHA into DevExpress Data Editors. Refer to official Google documentation for detailed information on this component: [reCAPTCHA - Developer's Guide](https://developers.google.com/recaptcha/intro).

![Data Editors Along With Captcha](./result.png)

## Implementation Details

1. Register your website in the [Google reCAPTCHA](https://www.google.com/recaptcha/admin/create) service to obtain site and secret keys.
2. Create a reusable [ReCaptchaComponent](./CS/ReCaptcha/Components/ReCaptchaComponent.razor) that loads Google reCAPTCHA APIs and renders the widget via JavaScript interop.
3. Handle success and expiration callbacks in the [ReCaptchaComponent](./CS/ReCaptcha/Components/ReCaptchaComponent.razor) to verify the captcha response with the Google verification service.
4. Add a [ReCaptchaComponent](./CS/ReCaptcha/Components/ReCaptchaComponent.razor) to a Form Layout component. Bind site and secret keys to the component.
5. Bind captcha success and expiration events to a flag variable to track the captcha status.

Note: This solution obtains keys from the following environment variables: `RECAPTCHA_SITE_KEY` and `RECAPTCHA_SECRET_KEY`. If these variables are not set, the application throws an exception to indicate missing configuration. Based on your requirements, you can adapt our implementation to retrieve keys from other sources, such as _appsettings.json_ or a configuration file.

## Files to Review

- [ReCaptchaComponent.razor](./CS/ReCaptcha/Components/ReCaptchaComponent.razor)
- [Index.razor](./CS/ReCaptcha/Components/Pages/Index.razor)

## Documentation

- [reCAPTCHA Documentation](https://developers.google.com/recaptcha/intro)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-data-editors-add-recaptcha&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-data-editors-add-recaptcha&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
