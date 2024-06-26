using OpenAI.Constants;

namespace LangChain.Providers.OpenRouter;

/// <summary>
/// Contains all the OpenRouter models.
/// </summary>
public static class OpenRouterModelProvider
{
    private static Dictionary<OpenRouterModelIds, ChatModels> Models { get; set; } = new()
    {
        { OpenRouterModelIds.NousCapybara7BFree, new ChatModels("nousresearch/nous-capybara-7b:free",4096,0,0)},
		{ OpenRouterModelIds.NousCapybara7BFree, new ChatModels("nousresearch/nous-capybara-7b:free",4096,0,0)},
		{ OpenRouterModelIds.Mistral7BInstructFree, new ChatModels("mistralai/mistral-7b-instruct:free",32768,0,0)},
		{ OpenRouterModelIds.Mythomist7BFree, new ChatModels("gryphe/mythomist-7b:free",32768,0,0)},
		{ OpenRouterModelIds.GoogleGemma7BFree, new ChatModels("google/gemma-7b-it:free",8192,0,0)},
		{ OpenRouterModelIds.PsyfighterV213B, new ChatModels("koboldai/psyfighter-13b-2",4096,0,0)},
		{ OpenRouterModelIds.NousHermes13B, new ChatModels("nousresearch/nous-hermes-llama2-13b",4096,0,0)},
		{ OpenRouterModelIds.MetaCodellama34BInstruct, new ChatModels("meta-llama/codellama-34b-instruct",8192,0,0)},
		{ OpenRouterModelIds.PhindCodellama34BV2, new ChatModels("phind/phind-codellama-34b",4096,0,0)},
		{ OpenRouterModelIds.NeuralChat7BV31, new ChatModels("intel/neural-chat-7b",4096,0,0)},
		{ OpenRouterModelIds.NousHermes2Mixtral8X7BDpo, new ChatModels("nousresearch/nous-hermes-2-mixtral-8x7b-dpo",32000,0,0)},
		{ OpenRouterModelIds.NousHermes2Mixtral8X7BSft, new ChatModels("nousresearch/nous-hermes-2-mixtral-8x7b-sft",32000,0,0)},
		{ OpenRouterModelIds.Llava13B, new ChatModels("haotian-liu/llava-13b",2048,0,0)},
		{ OpenRouterModelIds.NousHermes2Vision7BAlpha, new ChatModels("nousresearch/nous-hermes-2-vision-7b",4096,0,0)},
		{ OpenRouterModelIds.MetaLlamaV213BChat, new ChatModels("meta-llama/llama-2-13b-chat",4096,0,0)},
		{ OpenRouterModelIds.Synthia70B, new ChatModels("migtissera/synthia-70b",8192,0,0)},
		{ OpenRouterModelIds.PygmalionMythalion13B, new ChatModels("pygmalionai/mythalion-13b",8192,0,0)},
		{ OpenRouterModelIds.Mythomax13B, new ChatModels("gryphe/mythomax-l2-13b",4096,0,0)},
		{ OpenRouterModelIds.Xwin70B, new ChatModels("xwin-lm/xwin-lm-70b",8192,0,0)},
		{ OpenRouterModelIds.Goliath120B, new ChatModels("alpindale/goliath-120b",6144,0,0)},
		{ OpenRouterModelIds.Noromaid20B, new ChatModels("neversleep/noromaid-20b",8192,0,0)},
		{ OpenRouterModelIds.Mythomist7B, new ChatModels("gryphe/mythomist-7b",32768,0,0)},
		{ OpenRouterModelIds.MidnightRose70B, new ChatModels("sophosympatheia/midnight-rose-70b",4096,0,0)},
		{ OpenRouterModelIds.RemmSlerp13BExtended, new ChatModels("undi95/remm-slerp-l2-13b:extended",6144,0,0)},
		{ OpenRouterModelIds.Mythomax13BExtended, new ChatModels("gryphe/mythomax-l2-13b:extended",8192,0,0)},
		{ OpenRouterModelIds.MancerWeaverAlpha, new ChatModels("mancer/weaver",8000,0,0)},
		{ OpenRouterModelIds.NousCapybara7B, new ChatModels("nousresearch/nous-capybara-7b",4096,0,0)},
		{ OpenRouterModelIds.MetaCodellama70BInstruct, new ChatModels("codellama/codellama-70b-instruct",2048,0,0)},
		{ OpenRouterModelIds.OpenHermes2Mistral7B, new ChatModels("teknium/openhermes-2-mistral-7b",4096,0,0)},
		{ OpenRouterModelIds.OpenHermes25Mistral7B, new ChatModels("teknium/openhermes-2.5-mistral-7b",4096,0,0)},
		{ OpenRouterModelIds.RemmSlerp13B, new ChatModels("undi95/remm-slerp-l2-13b",4096,0,0)},
		{ OpenRouterModelIds.ToppyM7B, new ChatModels("undi95/toppy-m-7b",4096,0,0)},
		{ OpenRouterModelIds.Cinematika7BAlpha, new ChatModels("openrouter/cinematika-7b",8000,0,0)},
		{ OpenRouterModelIds.Yi34BChat, new ChatModels("01-ai/yi-34b-chat",4096,0,0)},
		{ OpenRouterModelIds.Yi34BBase, new ChatModels("01-ai/yi-34b",4096,0,0)},
		{ OpenRouterModelIds.Yi6BBase, new ChatModels("01-ai/yi-6b",4096,0,0)},
		{ OpenRouterModelIds.StripedhyenaNous7B, new ChatModels("togethercomputer/stripedhyena-nous-7b",32768,0,0)},
		{ OpenRouterModelIds.StripedhyenaHessian7BBase, new ChatModels("togethercomputer/stripedhyena-hessian-7b",32768,0,0)},
		{ OpenRouterModelIds.Mixtral8X7BBase, new ChatModels("mistralai/mixtral-8x7b",32768,0,0)},
		{ OpenRouterModelIds.NousHermes2Yi34B, new ChatModels("nousresearch/nous-hermes-yi-34b",4096,0,0)},
		{ OpenRouterModelIds.NousHermes2Mistral7BDpo, new ChatModels("nousresearch/nous-hermes-2-mistral-7b-dpo",8192,0,0)},
		{ OpenRouterModelIds.MistralOpenOrca7B, new ChatModels("open-orca/mistral-7b-openorca",8192,0,0)},
		{ OpenRouterModelIds.HuggingFaceZephyr7B, new ChatModels("huggingfaceh4/zephyr-7b-beta",4096,0,0)},
		{ OpenRouterModelIds.OpenAiGpt35Turbo, new ChatModels("openai/gpt-3.5-turbo",4095,0,0)},
		{ OpenRouterModelIds.OpenAiGpt35Turbo16K0125, new ChatModels("openai/gpt-3.5-turbo-0125",16385,0,0)},
		{ OpenRouterModelIds.OpenAiGpt35Turbo16K, new ChatModels("openai/gpt-3.5-turbo-16k",16385,0,0)},
		{ OpenRouterModelIds.OpenAiGpt4Turbo, new ChatModels("openai/gpt-4-turbo-preview",128000,0,0)},
		{ OpenRouterModelIds.OpenAiGpt4, new ChatModels("openai/gpt-4",8191,0,0)},
		{ OpenRouterModelIds.OpenAiGpt432K, new ChatModels("openai/gpt-4-32k",32767,0,0)},
		{ OpenRouterModelIds.OpenAiGpt4Vision, new ChatModels("openai/gpt-4-vision-preview",128000,0,0)},
		{ OpenRouterModelIds.OpenAiGpt35TurboInstruct, new ChatModels("openai/gpt-3.5-turbo-instruct",4095,0,0)},
		{ OpenRouterModelIds.GooglePalm2Chat, new ChatModels("google/palm-2-chat-bison",36864,0,0)},
		{ OpenRouterModelIds.GooglePalm2CodeChat, new ChatModels("google/palm-2-codechat-bison",28672,0,0)},
		{ OpenRouterModelIds.GooglePalm2Chat32K, new ChatModels("google/palm-2-chat-bison-32k",131072,0,0)},
		{ OpenRouterModelIds.GooglePalm2CodeChat32K, new ChatModels("google/palm-2-codechat-bison-32k",131072,0,0)},
		{ OpenRouterModelIds.GoogleGeminiPro10, new ChatModels("google/gemini-pro",131072,0,0)},
		{ OpenRouterModelIds.GoogleGeminiProVision10, new ChatModels("google/gemini-pro-vision",65536,0,0)},
		{ OpenRouterModelIds.PerplexityPplx70BOnline, new ChatModels("perplexity/pplx-70b-online",4096,0,0)},
		{ OpenRouterModelIds.PerplexityPplx7BOnline, new ChatModels("perplexity/pplx-7b-online",4096,0,0)},
		{ OpenRouterModelIds.PerplexityPplx7BChat, new ChatModels("perplexity/pplx-7b-chat",8192,0,0)},
		{ OpenRouterModelIds.PerplexityPplx70BChat, new ChatModels("perplexity/pplx-70b-chat",4096,0,0)},
		{ OpenRouterModelIds.PerplexitySonar7B, new ChatModels("perplexity/sonar-small-chat",16384,0,0)},
		{ OpenRouterModelIds.PerplexitySonar8X7B, new ChatModels("perplexity/sonar-medium-chat",16384,0,0)},
		{ OpenRouterModelIds.PerplexitySonar8X7BOnline, new ChatModels("perplexity/sonar-medium-online",12000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3Opus, new ChatModels("anthropic/claude-3-opus",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3Sonnet, new ChatModels("anthropic/claude-3-sonnet",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3Haiku, new ChatModels("anthropic/claude-3-haiku",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3OpusSelfModerated, new ChatModels("anthropic/claude-3-opus:beta",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3SonnetSelfModerated, new ChatModels("anthropic/claude-3-sonnet:beta",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaude3HaikuSelfModerated, new ChatModels("anthropic/claude-3-haiku:beta",200000,0,0)},
		{ OpenRouterModelIds.MetaLlamaV270BChat, new ChatModels("meta-llama/llama-2-70b-chat",4096,0,0)},
		{ OpenRouterModelIds.NousCapybara34B, new ChatModels("nousresearch/nous-capybara-34b",32768,0,0)},
		{ OpenRouterModelIds.Airoboros70B, new ChatModels("jondurbin/airoboros-l2-70b",4096,0,0)},
		{ OpenRouterModelIds.Bagel34Bv02, new ChatModels("jondurbin/bagel-34b",8000,0,0)},
		{ OpenRouterModelIds.ChronosHermes13BV2, new ChatModels("austism/chronos-hermes-13b",4096,0,0)},
		{ OpenRouterModelIds.Mistral7BInstruct, new ChatModels("mistralai/mistral-7b-instruct",32768,0,0)},
		{ OpenRouterModelIds.OpenChat35, new ChatModels("openchat/openchat-7b",8192,0,0)},
		{ OpenRouterModelIds.Lzlv70B, new ChatModels("lizpreciatior/lzlv-70b-fp16-hf",4096,0,0)},
		{ OpenRouterModelIds.Mixtral8X7BInstruct, new ChatModels("mistralai/mixtral-8x7b-instruct",32768,0,0)},
		{ OpenRouterModelIds.Dolphin26Mixtral8X7B, new ChatModels("cognitivecomputations/dolphin-mixtral-8x7b",32000,0,0)},
		{ OpenRouterModelIds.NoromaidMixtral8X7BInstruct, new ChatModels("neversleep/noromaid-mixtral-8x7b-instruct",8000,0,0)},
		{ OpenRouterModelIds.RwkvV5World3B, new ChatModels("rwkv/rwkv-5-world-3b",10000,0,0)},
		{ OpenRouterModelIds.RwkvV53BAiTown, new ChatModels("recursal/rwkv-5-3b-ai-town",10000,0,0)},
		{ OpenRouterModelIds.RwkvV5Eagle7B, new ChatModels("recursal/eagle-7b",10000,0,0)},
		{ OpenRouterModelIds.GoogleGemma7B, new ChatModels("google/gemma-7b-it",8192,0,0)},
		{ OpenRouterModelIds.DatabricksDbrx132BInstruct, new ChatModels("databricks/dbrx-instruct",32768,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV2, new ChatModels("anthropic/claude-2",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV21, new ChatModels("anthropic/claude-2.1",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV20, new ChatModels("anthropic/claude-2.0",100000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeInstantV1, new ChatModels("anthropic/claude-instant-1",100000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeInstantV12, new ChatModels("anthropic/claude-instant-1.2",100000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV2SelfModerated, new ChatModels("anthropic/claude-2:beta",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV21SelfModerated, new ChatModels("anthropic/claude-2.1:beta",200000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeV20SelfModerated, new ChatModels("anthropic/claude-2.0:beta",100000,0,0)},
		{ OpenRouterModelIds.AnthropicClaudeInstantV1SelfModerated, new ChatModels("anthropic/claude-instant-1:beta",100000,0,0)},
		{ OpenRouterModelIds.HuggingFaceZephyr7BFree, new ChatModels("huggingfaceh4/zephyr-7b-beta:free",4096,0,0)},
		{ OpenRouterModelIds.OpenChat35Free, new ChatModels("openchat/openchat-7b:free",8192,0,0)},
		{ OpenRouterModelIds.Mixtral8X7BInstructNitro, new ChatModels("mistralai/mixtral-8x7b-instruct:nitro",32768,0,0)},
		{ OpenRouterModelIds.MetaLlamaV270BChatNitro, new ChatModels("meta-llama/llama-2-70b-chat:nitro",4096,0,0)},
		{ OpenRouterModelIds.Mythomax13BNitro, new ChatModels("gryphe/mythomax-l2-13b:nitro",4096,0,0)},
		{ OpenRouterModelIds.Mistral7BInstructNitro, new ChatModels("mistralai/mistral-7b-instruct:nitro",32768,0,0)},
		{ OpenRouterModelIds.GoogleGemma7BNitro, new ChatModels("google/gemma-7b-it:nitro",8192,0,0)},
		{ OpenRouterModelIds.DatabricksDbrx132BInstructNitro, new ChatModels("databricks/dbrx-instruct:nitro",32768,0,0)},
		{ OpenRouterModelIds.MistralTiny, new ChatModels("mistralai/mistral-tiny",32000,0,0)},
		{ OpenRouterModelIds.MistralSmall, new ChatModels("mistralai/mistral-small",32000,0,0)},
		{ OpenRouterModelIds.MistralMedium, new ChatModels("mistralai/mistral-medium",32000,0,0)},
		{ OpenRouterModelIds.MistralLarge, new ChatModels("mistralai/mistral-large",32000,0,0)},
		{ OpenRouterModelIds.CohereCommand, new ChatModels("cohere/command",4096,0,0)},
		{ OpenRouterModelIds.CohereCommandR, new ChatModels("cohere/command-r",128000,0,0)},
		{ OpenRouterModelIds.CohereCommandRPlus, new ChatModels("cohere/command-r-plus",128000,0,0)},

    };

    public static ChatModels GetModelById(OpenRouterModelIds modelId)
    {
        if (Models.TryGetValue(modelId, out var id))
        {
            return id;
        }

        throw new ArgumentException($"Invalid Open Router Model {modelId}");
    }
}